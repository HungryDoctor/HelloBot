﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using HelloBotCommunication;
using HelloBotCommunication.ClientDataInterfaces;
using HelloBotModuleHelper;
using HtmlAgilityPack;
using Nigrimmist.Modules.Helpers;

namespace Nigrimmist.Modules.Commands
{
    public class SkypeChatSyncModule : IActionHandler
    {
        

        public List<CallCommandInfo> CallCommandList
        {
            get
            {
                return new List<CallCommandInfo>()
                {
                    new CallCommandInfo("get id" ),
                };
            }
        }

        public string CommandDescription { get { return @"Возвращает id чата."; } }
        public void HandleMessage(string command, string args, object clientData, Action<string, AnswerBehaviourType> sendMessageFunc)
        {
            var skypeData = clientData as ISkypeData;
            if (skypeData != null)
            {
                sendMessageFunc(skypeData.ChatId, AnswerBehaviourType.Text);
            }
        }
    }
}
