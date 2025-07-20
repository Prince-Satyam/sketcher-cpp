using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Artisian.UI
{
   /// <summary>
   /// Handles the events of the ribbons/buttons user interface.
   /// </summary>
   internal static class RibbonsEventManager
   {

      /// <summary>
      /// Handles the click event of the line button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public static void OnLineButtonClick(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Line button clicked!");
         //LineWrapper lineWrapperObj = new LineWrapper();
         //lineWrapperObj.Draw();
      }

      /// <summary>
      /// Handles the click event of the rectangle button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public static void OnFontButtonClick(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Font button clicked!");
         // Implement font-related functionality
      }

      /// <summary>
      /// Handles the click event of the circle button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public static void OnDeleteButtonClick(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Delete button clicked!");
         // Implement delete functionality
      }
   }
}
