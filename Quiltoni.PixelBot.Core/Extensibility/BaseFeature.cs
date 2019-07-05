﻿using System;

namespace Quiltoni.PixelBot.Core.Extensibility
{
	public abstract class BaseFeature : IFeature
	{
		public abstract string Name { get; }

		public bool IsVisible { get; private set; }

		public bool IsEnabled { get; private set; }

		protected BaseFeatureConfiguration Configuration { get; private set; }

		public virtual void Configure(BaseFeatureConfiguration configuration) {
			this.Configuration = configuration;
			this.IsEnabled = Configuration.IsEnabled;
			this.IsVisible = Configuration.IsVisible;
		}
	}

}
