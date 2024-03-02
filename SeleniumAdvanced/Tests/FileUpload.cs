using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    public class FileUploadTest : BaseTest
    {
        [Test]
        public void TestFileUpload()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            // Находим элемент для загрузки файла и отправляем путь к файлу
            IWebElement fileInput = Driver.FindElement(By.Id("file-upload"));
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyPath, "Resources", "Spring - Sandro Botticelli.png");
            fileInput.SendKeys(filePath);

            // Нажимаем кнопку загрузки файла
            IWebElement uploadButton = Driver.FindElement(By.Id("file-submit"));
            uploadButton.Click();

            // Проверяем, что имя файла на странице совпадает с именем загруженного файла
            IWebElement uploadedFileName = Driver.FindElement(By.Id("uploaded-files"));
            Assert.That(uploadedFileName.Text, Is.EqualTo("Spring - Sandro Botticelli.png"));
        }
    }
}
