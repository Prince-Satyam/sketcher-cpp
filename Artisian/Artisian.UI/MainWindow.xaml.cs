using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using System.Windows.Documents;

namespace Artisian.UI
{
   public partial class MainWindow : Window
   {
      /// <summary>
      /// Constructor
      /// </summary>
      public MainWindow()
      {
         InitializeComponent();
         Main();
         btnRibbon1.Click += RibbonsEventManager.OnLineButtonClick;
      }

      /// <summary>
      /// Entry point for the application
      /// </summary>
      public void Main()
      {
         // Test the canvas by adding a 3D cube
         Add3DCube();
         // Intialize the ribbon tabs and buttons

      }

      /// <summary>
      /// Creates a 3D cube and adds it to the scene
      /// </summary>
      private void Add3DCube()
      {
         MeshBuilder meshBuilder = new MeshBuilder();
         meshBuilder.AddBox(center: new Point3D(0, 0, 0), xlength: 2, ylength: 2, zlength: 2);

         GeometryModel3D cubeModel = new GeometryModel3D
         {
            Geometry = meshBuilder.ToMesh(),
            Material = MaterialHelper.CreateMaterial(Colors.Blue)
         };

         ModelVisual3D modelVisual = new ModelVisual3D { Content = cubeModel };
         SceneModel.Children.Add(modelVisual);
      }

      private void Ribbon_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
      {

      }

      private void hl1_Click(object sender, RoutedEventArgs e)
      {
         // Open the hyperlink in the default web browser
         Hyperlink hyperlink = sender as Hyperlink;
         if (hyperlink != null)
         {
            Process.Start(new ProcessStartInfo
            {
               FileName = hyperlink.NavigateUri.ToString(),
               UseShellExecute = true
            });
         }
      }
   }
}
