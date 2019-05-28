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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class MigrateToOtherRegionRequest : RpcAcsRequest<MigrateToOtherRegionResponse>
    {
        public MigrateToOtherRegionRequest()
            : base("Rds", "2014-08-15", "MigrateToOtherRegion", "Rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string targetVSwitchId;

		private long? ownerId;

		private string targetVpcId;

		private string targetZoneId;

		private string effectiveTime;

		private string dBInstanceId;

		private string targetRegionId;

		private string switchTime;

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

		public string TargetVSwitchId
		{
			get
			{
				return targetVSwitchId;
			}
			set	
			{
				targetVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "TargetVSwitchId", value);
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

		public string TargetVpcId
		{
			get
			{
				return targetVpcId;
			}
			set	
			{
				targetVpcId = value;
				DictionaryUtil.Add(QueryParameters, "TargetVpcId", value);
			}
		}

		public string TargetZoneId
		{
			get
			{
				return targetZoneId;
			}
			set	
			{
				targetZoneId = value;
				DictionaryUtil.Add(QueryParameters, "TargetZoneId", value);
			}
		}

		public string EffectiveTime
		{
			get
			{
				return effectiveTime;
			}
			set	
			{
				effectiveTime = value;
				DictionaryUtil.Add(QueryParameters, "EffectiveTime", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string TargetRegionId
		{
			get
			{
				return targetRegionId;
			}
			set	
			{
				targetRegionId = value;
				DictionaryUtil.Add(QueryParameters, "TargetRegionId", value);
			}
		}

		public string SwitchTime
		{
			get
			{
				return switchTime;
			}
			set	
			{
				switchTime = value;
				DictionaryUtil.Add(QueryParameters, "SwitchTime", value);
			}
		}

        public override MigrateToOtherRegionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MigrateToOtherRegionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
