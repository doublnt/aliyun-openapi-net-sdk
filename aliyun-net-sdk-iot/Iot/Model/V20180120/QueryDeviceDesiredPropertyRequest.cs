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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class QueryDeviceDesiredPropertyRequest : RpcAcsRequest<QueryDeviceDesiredPropertyResponse>
    {
        public QueryDeviceDesiredPropertyRequest()
            : base("Iot", "2018-01-20", "QueryDeviceDesiredProperty", "iot", "openAPI")
        {
        }

		private List<string> identifiers;

		private string iotId;

		private string iotInstanceId;

		private string deviceName;

		private string productKey;

		public List<string> Identifiers
		{
			get
			{
				return identifiers;
			}

			set
			{
				identifiers = value;
				for (int i = 0; i < identifiers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Identifier." + (i + 1) , identifiers[i]);
				}
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

        public override QueryDeviceDesiredPropertyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDeviceDesiredPropertyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}