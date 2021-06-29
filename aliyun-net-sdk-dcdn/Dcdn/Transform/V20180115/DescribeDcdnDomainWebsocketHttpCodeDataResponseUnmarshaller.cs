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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainWebsocketHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainWebsocketHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainWebsocketHttpCodeDataResponse describeDcdnDomainWebsocketHttpCodeDataResponse = new DescribeDcdnDomainWebsocketHttpCodeDataResponse();

			describeDcdnDomainWebsocketHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainWebsocketHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.RequestId");
			describeDcdnDomainWebsocketHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.DomainName");
			describeDcdnDomainWebsocketHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.StartTime");
			describeDcdnDomainWebsocketHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.EndTime");
			describeDcdnDomainWebsocketHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.DataInterval");

			List<DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule> describeDcdnDomainWebsocketHttpCodeDataResponse_dataPerInterval = new List<DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval.Length"); i++) {
				DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule dataModule = new DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval["+ i +"].TimeStamp");

				List<DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule.DescribeDcdnDomainWebsocketHttpCodeData_HttpCodeDataModule> dataModule_websocketHttpCodeDataPerInterval = new List<DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule.DescribeDcdnDomainWebsocketHttpCodeData_HttpCodeDataModule>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval["+ i +"].WebsocketHttpCodeDataPerInterval.Length"); j++) {
					DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule.DescribeDcdnDomainWebsocketHttpCodeData_HttpCodeDataModule httpCodeDataModule = new DescribeDcdnDomainWebsocketHttpCodeDataResponse.DescribeDcdnDomainWebsocketHttpCodeData_DataModule.DescribeDcdnDomainWebsocketHttpCodeData_HttpCodeDataModule();
					httpCodeDataModule.Code = _ctx.IntegerValue("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval["+ i +"].WebsocketHttpCodeDataPerInterval["+ j +"].Code");
					httpCodeDataModule.Proportion = _ctx.FloatValue("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval["+ i +"].WebsocketHttpCodeDataPerInterval["+ j +"].Proportion");
					httpCodeDataModule.Count = _ctx.FloatValue("DescribeDcdnDomainWebsocketHttpCodeData.DataPerInterval["+ i +"].WebsocketHttpCodeDataPerInterval["+ j +"].Count");

					dataModule_websocketHttpCodeDataPerInterval.Add(httpCodeDataModule);
				}
				dataModule.WebsocketHttpCodeDataPerInterval = dataModule_websocketHttpCodeDataPerInterval;

				describeDcdnDomainWebsocketHttpCodeDataResponse_dataPerInterval.Add(dataModule);
			}
			describeDcdnDomainWebsocketHttpCodeDataResponse.DataPerInterval = describeDcdnDomainWebsocketHttpCodeDataResponse_dataPerInterval;
        
			return describeDcdnDomainWebsocketHttpCodeDataResponse;
        }
    }
}
