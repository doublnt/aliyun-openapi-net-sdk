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
using Aliyun.Acs.Airec.Transform;
using Aliyun.Acs.Airec.Transform.V20201126;

namespace Aliyun.Acs.Airec.Model.V20201126
{
    public class DescribeSyncReportOutliersRequest : RoaAcsRequest<DescribeSyncReportOutliersResponse>
    {
        public DescribeSyncReportOutliersRequest()
            : base("Airec", "2020-11-26", "DescribeSyncReportOutliers", "airec", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v2/openapi/instances/[instanceId]/sync-reports/outliers";
			Method = MethodType.GET;
        }

		private string instanceId;

		private string levelType;

		private long? endTime;

		private long? startTime;

		private string type;

		private string key;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(PathParameters, "instanceId", value);
			}
		}

		public string LevelType
		{
			get
			{
				return levelType;
			}
			set	
			{
				levelType = value;
				DictionaryUtil.Add(QueryParameters, "levelType", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "endTime", value.ToString());
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "startTime", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "type", value);
			}
		}

		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "key", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSyncReportOutliersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSyncReportOutliersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
