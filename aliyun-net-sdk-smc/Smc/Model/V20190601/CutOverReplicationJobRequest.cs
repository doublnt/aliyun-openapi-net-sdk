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
using Aliyun.Acs.smc.Transform;
using Aliyun.Acs.smc.Transform.V20190601;

namespace Aliyun.Acs.smc.Model.V20190601
{
    public class CutOverReplicationJobRequest : RpcAcsRequest<CutOverReplicationJobResponse>
    {
        public CutOverReplicationJobRequest()
            : base("smc", "2019-06-01", "CutOverReplicationJob", "smc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceOwnerAccount;

		private long? ownerId;

		private string jobId;

		private bool? syncData;

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

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
			}
		}

		public bool? SyncData
		{
			get
			{
				return syncData;
			}
			set	
			{
				syncData = value;
				DictionaryUtil.Add(QueryParameters, "SyncData", value.ToString());
			}
		}

        public override CutOverReplicationJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CutOverReplicationJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
