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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class CreateStructSyncOrderResponseUnmarshaller
    {
        public static CreateStructSyncOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateStructSyncOrderResponse createStructSyncOrderResponse = new CreateStructSyncOrderResponse();

			createStructSyncOrderResponse.HttpResponse = _ctx.HttpResponse;
			createStructSyncOrderResponse.RequestId = _ctx.StringValue("CreateStructSyncOrder.RequestId");
			createStructSyncOrderResponse.Success = _ctx.BooleanValue("CreateStructSyncOrder.Success");
			createStructSyncOrderResponse.ErrorMessage = _ctx.StringValue("CreateStructSyncOrder.ErrorMessage");
			createStructSyncOrderResponse.ErrorCode = _ctx.StringValue("CreateStructSyncOrder.ErrorCode");

			List<string> createStructSyncOrderResponse_createOrderResult = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateStructSyncOrder.CreateOrderResult.Length"); i++) {
				createStructSyncOrderResponse_createOrderResult.Add(_ctx.StringValue("CreateStructSyncOrder.CreateOrderResult["+ i +"]"));
			}
			createStructSyncOrderResponse.CreateOrderResult = createStructSyncOrderResponse_createOrderResult;
        
			return createStructSyncOrderResponse;
        }
    }
}
