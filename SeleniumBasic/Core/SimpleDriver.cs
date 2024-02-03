using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public class SimpleDriver //�����, ���������� �� ������� ���������� ��������
{
    public IWebDriver Driver //������� ���� iwebdriver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            //return new ChromeDriver(
                //@"C:\Users\DevilMargo\Downloads\chromedriver-win64\chromedriver-win64\");

            //return new ChromeDriver(path + @"\Resources\");

            return new ChromeDriver(basePath + @"\Resources\");
        }
    } 
}