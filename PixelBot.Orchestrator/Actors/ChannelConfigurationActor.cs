﻿using Akka.Actor;
using PixelBot.Orchestrator.Data;
using Quiltoni.PixelBot.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PixelBot.Orchestrator.Actors
{
	public class ChannelConfigurationActor : ReceiveActor
	{
		private readonly IChannelConfigurationContext _Context;

		public ChannelConfigurationActor(IChannelConfigurationContext context)
		{
			_Context = context;

			Receive<GetConfigurationForChannel>(this.GetConfigurationForChannel);
			Receive<SaveConfigurationForChannel>(this.SaveConfigurationForChannel);

		}

		private void SaveConfigurationForChannel(SaveConfigurationForChannel msg)
		{

			_Context.SaveConfigurationForChannel(msg.ChannelName, msg.Config);
			ChannelManagerActor.Instance.Tell((NotifyChannelOfConfigurationUpdate)msg);

		}

		private void GetConfigurationForChannel(GetConfigurationForChannel msg)
		{

			var config = _Context.GetConfigurationForChannel(msg.ChannelName);
			Context.Sender.Tell(config);

		}
	}
}
