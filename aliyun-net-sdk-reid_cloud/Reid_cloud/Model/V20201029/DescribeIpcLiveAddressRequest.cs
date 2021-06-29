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
using Aliyun.Acs.reid_cloud.Transform;
using Aliyun.Acs.reid_cloud.Transform.V20201029;

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
    public class DescribeIpcLiveAddressRequest : RpcAcsRequest<DescribeIpcLiveAddressResponse>
    {
        public DescribeIpcLiveAddressRequest()
            : base("reid_cloud", "2020-10-29", "DescribeIpcLiveAddress", "1.2.1", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? ipcId;

		private long? storeId;

		private string protocolType;

		public long? IpcId
		{
			get
			{
				return ipcId;
			}
			set	
			{
				ipcId = value;
				DictionaryUtil.Add(BodyParameters, "IpcId", value.ToString());
			}
		}

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value.ToString());
			}
		}

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(BodyParameters, "ProtocolType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeIpcLiveAddressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeIpcLiveAddressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
