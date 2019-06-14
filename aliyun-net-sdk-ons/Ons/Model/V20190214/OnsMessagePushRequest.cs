/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20190214;

namespace Aliyun.Acs.Ons.Model.V20190214
{
    public class OnsMessagePushRequest : RpcAcsRequest<OnsMessagePushResponse>
    {
        public OnsMessagePushRequest()
            : base("Ons", "2019-02-14", "OnsMessagePush", "ons", "openAPI")
        {
        }

		private long? preventCache;

		private string clientId;

		private string instanceId;

		private string groupId;

		private string msgId;

		private string topic;

		public long? PreventCache
		{
			get
			{
				return preventCache;
			}
			set	
			{
				preventCache = value;
				DictionaryUtil.Add(QueryParameters, "PreventCache", value.ToString());
			}
		}

		public string ClientId
		{
			get
			{
				return clientId;
			}
			set	
			{
				clientId = value;
				DictionaryUtil.Add(QueryParameters, "ClientId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string MsgId
		{
			get
			{
				return msgId;
			}
			set	
			{
				msgId = value;
				DictionaryUtil.Add(QueryParameters, "MsgId", value);
			}
		}

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

        public override OnsMessagePushResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OnsMessagePushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}