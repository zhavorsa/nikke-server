﻿using nksrv.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nksrv.LobbyServer.Msgs.User
{
    [PacketPath("/ProfileCard/Possession/Get")]
    public class GetProfileCardPossession : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqProfileCardObjectList>();

            var response = new ResProfileCardObjectList();
            // TODO
            WriteData(response);
        }
    }
}
