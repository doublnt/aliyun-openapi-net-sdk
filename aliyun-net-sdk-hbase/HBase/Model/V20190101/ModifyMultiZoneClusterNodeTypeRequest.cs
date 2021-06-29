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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class ModifyMultiZoneClusterNodeTypeRequest : RpcAcsRequest<ModifyMultiZoneClusterNodeTypeResponse>
    {
        public ModifyMultiZoneClusterNodeTypeRequest()
            : base("HBase", "2019-01-01", "ModifyMultiZoneClusterNodeType", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string logInstanceType;

		private string clusterId;

		private string masterInstanceType;

		private string coreInstanceType;

		public string LogInstanceType
		{
			get
			{
				return logInstanceType;
			}
			set	
			{
				logInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "LogInstanceType", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string MasterInstanceType
		{
			get
			{
				return masterInstanceType;
			}
			set	
			{
				masterInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "MasterInstanceType", value);
			}
		}

		public string CoreInstanceType
		{
			get
			{
				return coreInstanceType;
			}
			set	
			{
				coreInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "CoreInstanceType", value);
			}
		}

        public override ModifyMultiZoneClusterNodeTypeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyMultiZoneClusterNodeTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
