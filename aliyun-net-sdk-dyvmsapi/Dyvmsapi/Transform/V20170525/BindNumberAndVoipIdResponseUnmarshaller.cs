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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class BindNumberAndVoipIdResponseUnmarshaller
    {
        public static BindNumberAndVoipIdResponse Unmarshall(UnmarshallerContext context)
        {
			BindNumberAndVoipIdResponse bindNumberAndVoipIdResponse = new BindNumberAndVoipIdResponse();

			bindNumberAndVoipIdResponse.HttpResponse = context.HttpResponse;
			bindNumberAndVoipIdResponse.RequestId = context.StringValue("BindNumberAndVoipId.RequestId");
			bindNumberAndVoipIdResponse.Code = context.StringValue("BindNumberAndVoipId.Code");
			bindNumberAndVoipIdResponse.Module = context.StringValue("BindNumberAndVoipId.Module");
			bindNumberAndVoipIdResponse.Message = context.StringValue("BindNumberAndVoipId.Message");
        
			return bindNumberAndVoipIdResponse;
        }
    }
}
