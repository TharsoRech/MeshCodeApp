﻿namespace MeshCodeApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Login(new LoginViewModel());
	}
}
