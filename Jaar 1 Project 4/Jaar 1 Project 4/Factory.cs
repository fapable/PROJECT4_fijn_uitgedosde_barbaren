using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

//The factory design pattern
//TODO find out where the button must be loaded

namespace Jaar_1_Project_4 {
    class Factory {
    }
    //The ButtonFactory creates a button
    public abstract class ButtonFactory {
        public enum HorizontalAllignmentEnum { left, right, center, stretch }
        public enum VerticalAlignmentEnum  {top,center, stretch, bottom }
        public static Button CreateButton(string text, HorizontalAllignmentEnum horizontalAllignment, VerticalAlignmentEnum verticalAllignment, double rectLeftTickness, double rectUpperTickness, double rectRighTickness, double rectLowerTickness, int height, int width) {
            Button button = new Button();
            button.Content = text;
            button.HorizontalAlignment = convertHorizontalAllignment(horizontalAllignment);
            button.VerticalAlignment = converVerticalAllignment(verticalAllignment);
            button.Margin = new Thickness(rectLeftTickness, rectUpperTickness, rectRighTickness, rectLowerTickness);
            button.Height = height;
            button.Width = width;
  
            return button;
        }
        private static HorizontalAlignment convertHorizontalAllignment(HorizontalAllignmentEnum position) {
            switch (position) {
                case (HorizontalAllignmentEnum.left):
                    return HorizontalAlignment.Left;
                case (HorizontalAllignmentEnum.center):
                    return HorizontalAlignment.Center;
                case (HorizontalAllignmentEnum.right):
                    return HorizontalAlignment.Right;
                case (HorizontalAllignmentEnum.stretch):
                    return HorizontalAlignment.Stretch;
                default:
                    return HorizontalAlignment.Stretch;
            }
        }
        private static VerticalAlignment converVerticalAllignment(VerticalAlignmentEnum position) {
            switch (position) {
                case (VerticalAlignmentEnum.top):
                    return VerticalAlignment.Top;
                case (VerticalAlignmentEnum.stretch):
                    return VerticalAlignment.Stretch;
                case (VerticalAlignmentEnum.bottom):
                    return VerticalAlignment.Bottom;
                case (VerticalAlignmentEnum.center):
                    return VerticalAlignment.Center;
                default:
                    return VerticalAlignment.Center;
            }
        }
    }
}
