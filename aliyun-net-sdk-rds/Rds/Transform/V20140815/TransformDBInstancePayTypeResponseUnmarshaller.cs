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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class TransformDBInstancePayTypeResponseUnmarshaller
    {
        public static TransformDBInstancePayTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TransformDBInstancePayTypeResponse transformDBInstancePayTypeResponse = new TransformDBInstancePayTypeResponse();

			transformDBInstancePayTypeResponse.HttpResponse = _ctx.HttpResponse;
			transformDBInstancePayTypeResponse.RequestId = _ctx.StringValue("TransformDBInstancePayType.RequestId");
			transformDBInstancePayTypeResponse.OrderId = _ctx.LongValue("TransformDBInstancePayType.OrderId");
			transformDBInstancePayTypeResponse.ChargeType = _ctx.StringValue("TransformDBInstancePayType.ChargeType");
			transformDBInstancePayTypeResponse.ExpiredTime = _ctx.StringValue("TransformDBInstancePayType.ExpiredTime");
			transformDBInstancePayTypeResponse.DBInstanceId = _ctx.StringValue("TransformDBInstancePayType.DBInstanceId");
        
			return transformDBInstancePayTypeResponse;
        }
    }
}