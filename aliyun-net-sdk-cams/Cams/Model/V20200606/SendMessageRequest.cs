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
using Aliyun.Acs.cams.Transform;
using Aliyun.Acs.cams.Transform.V20200606;

namespace Aliyun.Acs.cams.Model.V20200606
{
    public class SendMessageRequest : RpcAcsRequest<SendMessageResponse>
    {
        public SendMessageRequest()
            : base("cams", "2020-06-06", "SendMessage", "cams", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string messageType;

		private string templateBodyParams;

		private string link;

		private string caption;

		private string type;

		private string channelType;

		private string from;

		private string text;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string to;

		private string templateCode;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string MessageType
		{
			get
			{
				return messageType;
			}
			set	
			{
				messageType = value;
				DictionaryUtil.Add(BodyParameters, "MessageType", value);
			}
		}

		public string TemplateBodyParams
		{
			get
			{
				return templateBodyParams;
			}
			set	
			{
				templateBodyParams = value;
				DictionaryUtil.Add(BodyParameters, "TemplateBodyParams", value);
			}
		}

		public string Link
		{
			get
			{
				return link;
			}
			set	
			{
				link = value;
				DictionaryUtil.Add(BodyParameters, "Link", value);
			}
		}

		public string Caption
		{
			get
			{
				return caption;
			}
			set	
			{
				caption = value;
				DictionaryUtil.Add(BodyParameters, "Caption", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string ChannelType
		{
			get
			{
				return channelType;
			}
			set	
			{
				channelType = value;
				DictionaryUtil.Add(BodyParameters, "ChannelType", value);
			}
		}

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(BodyParameters, "From", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "Text", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(BodyParameters, "To", value);
			}
		}

		public string TemplateCode
		{
			get
			{
				return templateCode;
			}
			set	
			{
				templateCode = value;
				DictionaryUtil.Add(BodyParameters, "TemplateCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendMessageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendMessageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
