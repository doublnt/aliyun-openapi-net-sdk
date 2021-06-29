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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class SearchObjectResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private SearchObject_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public SearchObject_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class SearchObject_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<SearchObject_RecordsItem> records;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<SearchObject_RecordsItem> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class SearchObject_RecordsItem
			{

				private string compareResult;

				private string deviceID;

				private long? shotTime;

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBtmX;

				private int? rightBtmY;

				private float? score;

				private string sourceID;

				private string sourceImagePath;

				private string sourceImageUrl;

				private string targetImagePath;

				private string targetImageUrl;

				public string CompareResult
				{
					get
					{
						return compareResult;
					}
					set	
					{
						compareResult = value;
					}
				}

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
					}
				}

				public long? ShotTime
				{
					get
					{
						return shotTime;
					}
					set	
					{
						shotTime = value;
					}
				}

				public int? LeftTopX
				{
					get
					{
						return leftTopX;
					}
					set	
					{
						leftTopX = value;
					}
				}

				public int? LeftTopY
				{
					get
					{
						return leftTopY;
					}
					set	
					{
						leftTopY = value;
					}
				}

				public int? RightBtmX
				{
					get
					{
						return rightBtmX;
					}
					set	
					{
						rightBtmX = value;
					}
				}

				public int? RightBtmY
				{
					get
					{
						return rightBtmY;
					}
					set	
					{
						rightBtmY = value;
					}
				}

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public string SourceID
				{
					get
					{
						return sourceID;
					}
					set	
					{
						sourceID = value;
					}
				}

				public string SourceImagePath
				{
					get
					{
						return sourceImagePath;
					}
					set	
					{
						sourceImagePath = value;
					}
				}

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

				public string TargetImagePath
				{
					get
					{
						return targetImagePath;
					}
					set	
					{
						targetImagePath = value;
					}
				}

				public string TargetImageUrl
				{
					get
					{
						return targetImageUrl;
					}
					set	
					{
						targetImageUrl = value;
					}
				}
			}
		}
	}
}
