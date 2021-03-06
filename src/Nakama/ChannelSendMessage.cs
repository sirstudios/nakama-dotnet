/**
 * Copyright 2018 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Runtime.Serialization;

namespace Nakama
{
    /// <summary>
    /// Send a chat message to a channel on the server.
    /// </summary>
    internal class ChannelSendMessage
    {
        [DataMember(Name="channel_id"), Preserve]
        public string ChannelId { get; set; }

        [DataMember(Name="content"), Preserve]
        public string Content { get; set; }

        public override string ToString()
        {
            return $"ChannelSendMessage(ChannelId='{ChannelId}', Content='{Content}')";
        }
    }
}
