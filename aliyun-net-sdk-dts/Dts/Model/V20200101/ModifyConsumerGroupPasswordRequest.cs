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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class ModifyConsumerGroupPasswordRequest : RpcAcsRequest<ModifyConsumerGroupPasswordResponse>
    {
        public ModifyConsumerGroupPasswordRequest()
            : base("Dts", "2020-01-01", "ModifyConsumerGroupPassword", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string consumerGroupName;

		private string consumerGroupID;

		private string subscriptionInstanceId;

		private string ownerId;

		private string consumerGroupNewPassword;

		private string consumerGroupPassword;

		private string accountId;

		private string consumerGroupUserName;

		public string ConsumerGroupName
		{
			get
			{
				return consumerGroupName;
			}
			set	
			{
				consumerGroupName = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerGroupName", value);
			}
		}

		public string ConsumerGroupID
		{
			get
			{
				return consumerGroupID;
			}
			set	
			{
				consumerGroupID = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerGroupID", value);
			}
		}

		public string SubscriptionInstanceId
		{
			get
			{
				return subscriptionInstanceId;
			}
			set	
			{
				subscriptionInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceId", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string ConsumerGroupNewPassword
		{
			get
			{
				return consumerGroupNewPassword;
			}
			set	
			{
				consumerGroupNewPassword = value;
				DictionaryUtil.Add(QueryParameters, "consumerGroupNewPassword", value);
			}
		}

		public string ConsumerGroupPassword
		{
			get
			{
				return consumerGroupPassword;
			}
			set	
			{
				consumerGroupPassword = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerGroupPassword", value);
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public string ConsumerGroupUserName
		{
			get
			{
				return consumerGroupUserName;
			}
			set	
			{
				consumerGroupUserName = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerGroupUserName", value);
			}
		}

        public override ModifyConsumerGroupPasswordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyConsumerGroupPasswordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
