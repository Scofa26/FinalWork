using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Elements
{
    public class TableCell
    {
        private UIElement _uiElement;

        public TableCell(UIElement uiElement)
        {
            _uiElement = uiElement;
        }

        public UIElement DeleteAction() => _uiElement.FindUIElement(By.TagName("div"));
        public string Text => _uiElement.Text;
    }
}
