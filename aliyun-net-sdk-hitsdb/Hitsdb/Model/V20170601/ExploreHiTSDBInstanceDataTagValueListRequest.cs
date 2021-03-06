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
using Aliyun.Acs.hitsdb.Transform;
using Aliyun.Acs.hitsdb.Transform.V20170601;

namespace Aliyun.Acs.hitsdb.Model.V20170601
{
    public class ExploreHiTSDBInstanceDataTagValueListRequest : RpcAcsRequest<ExploreHiTSDBInstanceDataTagValueListResponse>
    {
        public ExploreHiTSDBInstanceDataTagValueListRequest()
            : base("hitsdb", "2017-06-01", "ExploreHiTSDBInstanceDataTagValueList", "hitsdb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reverseVpcIp;

		private long? resourceOwnerId;

		private string prefix;

		private int? reverseVpcPort;

		private string passWord;

		private string securityToken;

		private string resourceOwnerAccount;

		private long? max;

		private string ownerAccount;

		private long? ownerId;

		private string instanceId;

		private string tagKey;

		private string userName;

		public string ReverseVpcIp
		{
			get
			{
				return reverseVpcIp;
			}
			set	
			{
				reverseVpcIp = value;
				DictionaryUtil.Add(QueryParameters, "ReverseVpcIp", value);
			}
		}

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

		public string Prefix
		{
			get
			{
				return prefix;
			}
			set	
			{
				prefix = value;
				DictionaryUtil.Add(QueryParameters, "Prefix", value);
			}
		}

		public int? ReverseVpcPort
		{
			get
			{
				return reverseVpcPort;
			}
			set	
			{
				reverseVpcPort = value;
				DictionaryUtil.Add(QueryParameters, "ReverseVpcPort", value.ToString());
			}
		}

		public string PassWord
		{
			get
			{
				return passWord;
			}
			set	
			{
				passWord = value;
				DictionaryUtil.Add(QueryParameters, "PassWord", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
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

		public long? Max
		{
			get
			{
				return max;
			}
			set	
			{
				max = value;
				DictionaryUtil.Add(QueryParameters, "Max", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string TagKey
		{
			get
			{
				return tagKey;
			}
			set	
			{
				tagKey = value;
				DictionaryUtil.Add(QueryParameters, "TagKey", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExploreHiTSDBInstanceDataTagValueListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExploreHiTSDBInstanceDataTagValueListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
