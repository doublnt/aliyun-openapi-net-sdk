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
using Aliyun.Acs.dg.Model.V20190327;

namespace Aliyun.Acs.dg.Transform.V20190327
{
    public class ListDatabaseAccessPointResponseUnmarshaller
    {
        public static ListDatabaseAccessPointResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatabaseAccessPointResponse listDatabaseAccessPointResponse = new ListDatabaseAccessPointResponse();

			listDatabaseAccessPointResponse.HttpResponse = _ctx.HttpResponse;
			listDatabaseAccessPointResponse.RequestId = _ctx.StringValue("ListDatabaseAccessPoint.RequestId");
			listDatabaseAccessPointResponse.Success = _ctx.StringValue("ListDatabaseAccessPoint.Success");
			listDatabaseAccessPointResponse.Code = _ctx.StringValue("ListDatabaseAccessPoint.Code");
			listDatabaseAccessPointResponse.ErrorMsg = _ctx.StringValue("ListDatabaseAccessPoint.ErrorMsg");
			listDatabaseAccessPointResponse.Data = _ctx.StringValue("ListDatabaseAccessPoint.Data");
			listDatabaseAccessPointResponse.Count = _ctx.IntegerValue("ListDatabaseAccessPoint.Count");
        
			return listDatabaseAccessPointResponse;
        }
    }
}
