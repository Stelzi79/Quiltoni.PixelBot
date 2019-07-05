﻿using System;
using System.Collections.Generic;

namespace Quiltoni.PixelBot.Core.Extensibility
{
	public class BaseFeatureConfiguration
	{

		/// <summary>
		/// has the owner of this channel configured this feature?
		/// </summary>
		public bool IsEnabled { get; set; }

		/// <summary>
		/// does the owner of this channel have access to this feature?
		/// </summary>
		public bool IsVisible { get; set; } = true;

		public void ParseConfiguration(string jsonConfiguration) {

			// TODO: Load JSON Configuration and assign to properties

		}

	}

}