using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");

        IWebElement weightInput = Driver.FindElement(By.Name("weight"));
        IWebElement heightInput = Driver.FindElement(By.Name("height"));
        IWebElement calcButton = Driver.FindElement(By.Id("calc-mass-c"));
        
        weightInput.SendKeys("80");
        heightInput.SendKeys("183");
        calcButton.Click();

        IWebElement resultText = Driver.FindElement(By.Id("imt-result"));
        Assert.That(resultText.Text, Is.EqualTo("23.9 - Норма"));

    }

    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");

        //Thread.Sleep(3000);
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));

        IWebElement ageInput = Driver.FindElement(By.Id("age"));
        IWebElement selectSexDropdown = Driver.FindElement(By.Id("sex"));
        SelectElement selectSexElement = new SelectElement(selectSexDropdown);
        IWebElement crInput = Driver.FindElement(By.Id("cr"));
        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);
        IWebElement selectRace = Driver.FindElement(By.Id("race"));
        SelectElement selectRaceElement = new SelectElement(selectRace);
        IWebElement massInput = Driver.FindElement(By.Id("mass"));
        IWebElement growInput = Driver.FindElement(By.Id("grow"));
        IWebElement countButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));

        ageInput.SendKeys("21");
        selectSexElement.SelectByValue("F");
        Thread.Sleep(2000);
        crInput.SendKeys("85");
        selectElement.SelectByIndex(0);
        Thread.Sleep(2000);
        selectRaceElement.SelectByValue("O");
        Thread.Sleep(2000);
        massInput.SendKeys("48");
        growInput.SendKeys("158");
        countButton.Click();
        Thread.Sleep(2000);

        IWebElement resultMdrd = Driver.FindElement(By.Id("mdrd_res"));
        Assert.That(resultMdrd.Text, Is.EqualTo("73.23"));

        IWebElement resultCkd_epi = Driver.FindElement(By.Id("ckd_epi_res"));
        Assert.That(resultCkd_epi.Text, Is.EqualTo("84.38"));

        IWebElement resultCge = Driver.FindElement(By.Id("cge_res"));
        Assert.That(resultCge.Text, Is.EqualTo("70.13"));

        IWebElement resultsChwartz = Driver.FindElement(By.Id("schwartz_res"));
        Assert.That(resultsChwartz.Text, Is.EqualTo("91.08"));

    }

    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement lengthInput = Driver.FindElement(By.Id("ln_room_id"));
        lengthInput.Clear();
        lengthInput.SendKeys("400");

        IWebElement widthInput = Driver.FindElement(By.Id("wd_room_id"));
        widthInput.Clear();
        widthInput.SendKeys("300");

        IWebElement plankLengthInput = Driver.FindElement(By.Id("ln_lam_id"));
        plankLengthInput.Clear();
        plankLengthInput.SendKeys("1200");

        IWebElement plankWidthInput = Driver.FindElement(By.Id("wd_lam_id"));
        plankWidthInput.Clear();
        plankWidthInput.SendKeys("190");

        IWebElement plankCountInput = Driver.FindElement(By.Id("n_packing"));
        plankCountInput.Clear();
        plankCountInput.SendKeys("16");

        IWebElement marginInput = Driver.FindElement(By.Id("area"));
        marginInput.SendKeys("8");

        IWebElement directionRadio = Driver.FindElement(By.Id("direction-laminate-id1"));
        directionRadio.Click();
        
        IWebElement methodSelect = Driver.FindElement(By.Id("laying_method_laminate"));
        SelectElement methodDropdown = new SelectElement(methodSelect);
        methodDropdown.SelectByText("с использованием отрезанного элемента");
        Thread.Sleep(2000);
        // Нажатие кнопки "Рассчитать"
        IWebElement calculateButton = Driver.FindElement(By.Id("btn_calculate"));
        calculateButton.Click();
        Thread.Sleep(2000);
        // Проверка рассчитанных результатов
       //Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);

        IWebElement calcResult1 = Driver.FindElement(By.XPath("//*[contains(text(),'Требуемое количество плашек ламината: ')]//descendant::span"));
        Assert.That(calcResult1.Text, Is.EqualTo("53"));

        IWebElement calcResult2 = Driver.FindElement(By.XPath("//*[contains(text(),'Количество упаковок ламината: ')]//descendant::span"));
        Assert.That(calcResult2.Text, Is.EqualTo("4"));
    }
}