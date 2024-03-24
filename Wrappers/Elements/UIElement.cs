using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements;

public class UIElement : IWebElement // Îáúÿâëåíèå êëàññà UIElement, ðåàëèçóþùåãî èíòåðôåéñ IWebElement 
{
    //çàäàåì ïåðåìåííûå
    private IWebDriver _webDriver; // Ïîëå äëÿ õðàíåíèÿ ýêçåìïëÿðà âåá-äðàéâåðà
    private WaitsHelper _waitsHelper; // Ïîëå äëÿ õðàíåíèÿ ýêçåìïëÿðà âñïîìîãàòåëüíîãî êëàññà îæèäàíèé
    private IWebElement _webElement; // Ïîëå äëÿ õðàíåíèÿ âåá-ýëåìåíòà
    private Actions _actions; // Ïîëå äëÿ õðàíåíèÿ äåéñòâèé ñ âåá-ýëåìåíòàìè

    private UIElement(IWebDriver webDriver) // Ïðèâàòíûé êîíñòðóêòîð ñ ïàðàìåòðîì webDriver
    {
        _webDriver = webDriver;
        _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        _actions = new Actions(webDriver);
    }

    public UIElement(IWebDriver webDriver, By by) : this(webDriver) // Ïóáëè÷íûé êîíñòðóêòîð ñ ïàðàìåòðàìè webDriver è by, âûçûâàåò ïðèâàòíûé êîíñòðóêòîð
    {
        _webElement = _waitsHelper.WaitForExists(by);
    }

    public UIElement(IWebDriver webDriver, IWebElement webElement) : this(webDriver) // Ïóáëè÷íûé êîíñòðóêòîð ñ ïàðàìåòðàìè webDriver è webElement, âûçûâàåò ïðèâàòíûé êîíñòðóêòîð
    {
        _webElement = webElement;
    }

    public IWebElement FindElement(By by) // Ìåòîä ïîèñêà âëîæåííîãî ýëåìåíòà ïî ëîêàòîðó By
    {
        return _waitsHelper.WaitChildElement(_webElement, by);
    }

    public UIElement FindUIElement(By by) // Ìåòîä ïîèñêà âëîæåííîãî ýëåìåíòà òèïà UIElement ïî ëîêàòîðó By
    {
        return new UIElement(_webDriver, FindElement(by));
    }

    public ReadOnlyCollection<IWebElement> FindElements(By by) // Ìåòîä ïîèñêà âñåõ âëîæåííûõ ýëåìåíòîâ ïî ëîêàòîðó By
    {
        return _webElement.FindElements(by);
    }

    public List<UIElement> FindUIElements(By by) // Ìåòîä ïîèñêà âñåõ âëîæåííûõ ýëåìåíòîâ òèïà UIElement ïî ëîêàòîðó By
    {
        var result = new List<UIElement>();
        foreach (var webElement in FindElements(by))
        {
            result.Add(new UIElement(_webDriver, webElement));
        }

        return result;
    }

    public void Clear() // Ìåòîä î÷èñòêè òåêñòîâîãî ïîëÿ ýëåìåíòà
    {
        _webElement.Clear();
    }

    public void SendKeys(string text) // Ìåòîä ââîäà òåêñòà â òåêñòîâîå ïîëå ýëåìåíòà
    {
        _webElement.SendKeys(text);
    }

    public void Submit() // Ìåòîä îòïðàâêè ôîðìû, åñëè ýëåìåíò ÿâëÿåòñÿ ôîðìîé
    {
        _webElement.Submit();
    }

    public void Click() // Ìåòîä êëèêà ïî ýëåìåíòó, îáðàáàòûâàåò ElementNotInteractableException
    {
        try
        {
            _webElement.Click();
        }
        catch (ElementNotInteractableException)
        {
            try
            {
                _actions
                    .MoveToElement(_webElement)
                    .Click()
                    .Build()
                    .Perform();
            }
            catch (Exception)
            {
                MoveToElement();
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].click();", _webElement);
            }
        }
    }

    public string GetAttribute(string attributeName) // Ìåòîä ïîëó÷åíèÿ çíà÷åíèÿ àòðèáóòà ýëåìåíòà
    {
        return _webElement.GetAttribute(attributeName);
    }

    public string GetDomAttribute(string attributeName) // Ìåòîä ïîëó÷åíèÿ çíà÷åíèÿ DOM-àòðèáóòà ýëåìåíòà
    {
        return _webElement.GetDomAttribute(attributeName);
    }

    public string GetDomProperty(string propertyName) // Ìåòîä ïîëó÷åíèÿ çíà÷åíèÿ DOM-ñâîéñòâà ýëåìåíòà
    {
        return _webElement.GetDomProperty(propertyName);
    }

    public string GetCssValue(string propertyName) // Ìåòîä ïîëó÷åíèÿ çíà÷åíèÿ CSS-ñâîéñòâà ýëåìåíòà
    {
        return _webElement.GetCssValue(propertyName);
    }

    public ISearchContext GetShadowRoot() // Ìåòîä ïîëó÷åíèÿ òåíåâîãî êîðíÿ ýëåìåíòà
    {
        return _webElement.GetShadowRoot();
    }

    public void MoveToElement() // Ìåòîä ïåðåìåùåíèÿ ê ýëåìåíòó íà ñòðàíèöå
    {
        ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", _webElement);
    }

    public void Hover() // Ìåòîä íàâåäåíèÿ êóðñîðà íà ýëåìåíò
    {
        _actions.MoveToElement(_webElement).Build().Perform();
    }

    public string TagName => _webElement.TagName; // Ñâîéñòâî äëÿ ïîëó÷åíèÿ èìåíè òåãà ýëåìåíòà

    public string Text // Ñâîéñòâî äëÿ ïîëó÷åíèÿ òåêñòîâîãî ñîäåðæèìîãî ýëåìåíòà
    {
        get
        {
            /*
            if (_webElement.Text != null || _webElement.Text.Equals(""))
            {
                if (GetAttribute("value").Equals(""))
                {
                    return GetAttribute("innerText");
                }

                return GetAttribute("value");
            }
            */

            return _webElement.Text;
        }
    }

    public bool Enabled => _webElement.Enabled; // Ñâîéñòâî, óêàçûâàþùåå, äîñòóïåí ëè ýëåìåíò äëÿ âçàèìîäåéñòâèÿ
    public bool Selected => _webElement.Selected; // Ñâîéñòâî, óêàçûâàþùåå, âûáðàí ëè ýëåìåíò
    public Point Location => _webElement.Location; // Ñâîéñòâî äëÿ ïîëó÷åíèÿ ïîçèöèè ýëåìåíòà íà ñòðàíèöå
    public Size Size => _webElement.Size; // Ñâîéñòâî äëÿ ïîëó÷åíèÿ ðàçìåðîâ ýëåìåíòà
    public bool Displayed => _webElement.Displayed; // Ñâîéñòâî, óêàçûâàþùåå, îòîáðàæàåòñÿ ëè ýëåìåíò íà ñòðàíèöå
}
