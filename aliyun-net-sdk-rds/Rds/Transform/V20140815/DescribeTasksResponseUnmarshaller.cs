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
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = context.HttpResponse;
			describeTasksResponse.RequestId = context.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.TotalRecordCount = context.IntegerValue("DescribeTasks.TotalRecordCount");
			describeTasksResponse.PageNumber = context.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.PageRecordCount = context.IntegerValue("DescribeTasks.PageRecordCount");

			List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo> describeTasksResponse_items = new List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo>();
			for (int i = 0; i < context.Length("DescribeTasks.Items.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_TaskProgressInfo taskProgressInfo = new DescribeTasksResponse.DescribeTasks_TaskProgressInfo();
				taskProgressInfo.DBName = context.StringValue("DescribeTasks.Items["+ i +"].DBName");
				taskProgressInfo.BeginTime = context.StringValue("DescribeTasks.Items["+ i +"].BeginTime");
				taskProgressInfo.ProgressInfo = context.StringValue("DescribeTasks.Items["+ i +"].ProgressInfo");
				taskProgressInfo.FinishTime = context.StringValue("DescribeTasks.Items["+ i +"].FinishTime");
				taskProgressInfo.TaskAction = context.StringValue("DescribeTasks.Items["+ i +"].TaskAction");
				taskProgressInfo.TaskId = context.StringValue("DescribeTasks.Items["+ i +"].TaskId");
				taskProgressInfo.Progress = context.StringValue("DescribeTasks.Items["+ i +"].Progress");
				taskProgressInfo.ExpectedFinishTime = context.StringValue("DescribeTasks.Items["+ i +"].ExpectedFinishTime");
				taskProgressInfo.Status = context.StringValue("DescribeTasks.Items["+ i +"].Status");
				taskProgressInfo.TaskErrorCode = context.StringValue("DescribeTasks.Items["+ i +"].TaskErrorCode");
				taskProgressInfo.TaskErrorMessage = context.StringValue("DescribeTasks.Items["+ i +"].TaskErrorMessage");

				describeTasksResponse_items.Add(taskProgressInfo);
			}
			describeTasksResponse.Items = describeTasksResponse_items;
        
			return describeTasksResponse;
        }
    }
}
