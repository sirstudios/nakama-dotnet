/**
 * Copyright 2020 The Nakama Authors
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

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.SocketInternal
{
    /// <summary>
    /// A join message for a match on the server.
    /// </summary>
    [DataContract]
    public class MatchJoinMessage
    {
        [DataMember(Name="match_id", Order = 1), Preserve]
        public string MatchId { get; set; }

        [DataMember(Name="token", Order = 2), Preserve]
        public string Token { get; set; }

        [DataMember(Name="metadata", Order = 3), Preserve]
        public IDictionary<string, string> Metadata { get; set; }

        public override string ToString()
        {
            return $"MatchJoinMessage(MatchId='{MatchId}', Token='{Token}, Metadata='{Metadata}')";
        }
    }
}