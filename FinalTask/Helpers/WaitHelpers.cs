using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FinalTask.Elements;

namespace FinalTask.Helpers
{
    public class WaitHelpers(IWebDriver driver, TimeSpan timeout)
    {
        private readonly WebDriverWait _wait = new(driver, timeout);
        public IWebElement WaitForVisibilityLocatedBy(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));

        }

        public ReadOnlyCollection<IWebElement> WaitForAllVisibleElementsLocatedBy(By locator)
        {
            return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
        public ReadOnlyCollection<IWebElement> PresenceOfAllElementsLocatedBy(By locator)
        {
            return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
        }
        public IWebElement WaitForExists(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public bool WaitForElementInvisible(By locator)
        {
            return _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public bool WaitForElementInvisible(IWebElement webElement)
        {
            try
            {
                // Проверка, видим ли элемент
                return _wait.Until(d => !webElement.Displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, считаем его невидимым
                return true;
            }
            catch (StaleElementReferenceException)
            {
                // Если элемент устарел, считаем его невидимым
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException("Элемент не стал невидимым в течение заданного времени");
            }
        }
        public bool WaitForVisibility(IWebElement element)
        {
            return _wait.Until(_ => element.Displayed);
        }

        public UIElement WaitChildElement(IWebElement webElement, By by)
        {
            return new UIElement(driver, _wait.Until(_ => webElement.FindElement(by)));
        }

        public IWebElement FluentWaitForElement(By locator)
        {
            // Инициализация и параметризация FluentWait
            WebDriverWait fluentWait = new WebDriverWait(driver, TimeSpan.FromSeconds(12))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50)
            };

            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            // Использование
            return fluentWait.Until(_ => driver.FindElement(locator));
        }
    }
}
