﻿using System;
using System.Diagnostics.Tracing;
using Microsoft.AspNetCore.Routing;
using Quiltoni.PixelBot.Core;

namespace Quiltoni.PixelBot.Core.Extensibility
{

	[ActivatingEvents(StreamEvent.OnMessage)]
	public interface IFeature
	{

		/// <summary>
		/// Configure the feature for a specific channel
		/// </summary>
		/// <param name="configuration">Configuration for the feature specific to a channel</param>
		/// <param name="channel">The channel to be configured</param>
		void Configure(BaseFeatureConfiguration configuration);

		string Name { get; }

		bool IsVisible { get; }

		bool IsEnabled { get; }

		void RegisterRoutes(IEndpointRouteBuilder routes);

		void FeatureTriggered(string notifyAction);

		Action<string> BroadcastMessage { set; }

		Action<string, string> WhisperMessage { set; }

	}

}
