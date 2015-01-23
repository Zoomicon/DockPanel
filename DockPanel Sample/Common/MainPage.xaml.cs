﻿using Microsoft.Phone.Controls;
using System.Windows.Controls;

namespace DockPanelSample
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();
			DockPanel panel = new DockPanel();
			panel.LastChildFill = true;

			Button btn1 = new Button() { Content = "Bottom" };
			btn1.SetValue(DockPanel.DockProperty, Dock.Bottom);

			Button btn2 = new Button() { Content = "Top"};
			btn2.SetValue(DockPanel.DockProperty, Dock.Top);

			Button btn3 = new Button() { Content = "Right" };
			btn3.SetValue(DockPanel.DockProperty, Dock.Right);

			Button btn4 = new Button() { Content = "Left" };
			btn4.SetValue(DockPanel.DockProperty, Dock.Left);


			panel.Children.Add(btn1);
			panel.Children.Add(btn2);
			panel.Children.Add(btn3);
			panel.Children.Add(btn4);
			this.ContentPanel.Children.Add(panel);
		}
	}
}