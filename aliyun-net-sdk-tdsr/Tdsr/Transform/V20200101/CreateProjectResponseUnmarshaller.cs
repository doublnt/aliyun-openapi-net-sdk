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
using Aliyun.Acs.tdsr.Model.V20200101;

namespace Aliyun.Acs.tdsr.Transform.V20200101
{
    public class CreateProjectResponseUnmarshaller
    {
        public static CreateProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateProjectResponse createProjectResponse = new CreateProjectResponse();

			createProjectResponse.HttpResponse = _ctx.HttpResponse;
			createProjectResponse.RequestId = _ctx.StringValue("CreateProject.RequestId");
			createProjectResponse.Id = _ctx.LongValue("CreateProject.Id");
			createProjectResponse.Name = _ctx.StringValue("CreateProject.Name");
			createProjectResponse.Success = _ctx.BooleanValue("CreateProject.Success");
			createProjectResponse.ErrMessage = _ctx.StringValue("CreateProject.ErrMessage");
        
			return createProjectResponse;
        }
    }
}
