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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListOutboundOrderCaseSkusResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private string orderByField;

		private int? pageNumber;

		private string orderByMethod;

		private string requestId;

		private bool? success;

		private List<ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel> skuTags;

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

		public string OrderByField
		{
			get
			{
				return orderByField;
			}
			set	
			{
				orderByField = value;
			}
		}

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

		public string OrderByMethod
		{
			get
			{
				return orderByMethod;
			}
			set	
			{
				orderByMethod = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel> SkuTags
		{
			get
			{
				return skuTags;
			}
			set	
			{
				skuTags = value;
			}
		}

		public class ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel
		{

			private int? bindingQuantity;

			private string barcodeId;

			private string barcode;

			private string productCode;

			private string productSizeId;

			private string productColorId;

			private string caseId;

			private string productColorName;

			private string productName;

			private string productSizeCode;

			private string productSizeName;

			private string caseCode;

			private string productId;

			private string productColorCode;

			private int? boxQuantity;

			public int? BindingQuantity
			{
				get
				{
					return bindingQuantity;
				}
				set	
				{
					bindingQuantity = value;
				}
			}

			public string BarcodeId
			{
				get
				{
					return barcodeId;
				}
				set	
				{
					barcodeId = value;
				}
			}

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string ProductSizeId
			{
				get
				{
					return productSizeId;
				}
				set	
				{
					productSizeId = value;
				}
			}

			public string ProductColorId
			{
				get
				{
					return productColorId;
				}
				set	
				{
					productColorId = value;
				}
			}

			public string CaseId
			{
				get
				{
					return caseId;
				}
				set	
				{
					caseId = value;
				}
			}

			public string ProductColorName
			{
				get
				{
					return productColorName;
				}
				set	
				{
					productColorName = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ProductSizeCode
			{
				get
				{
					return productSizeCode;
				}
				set	
				{
					productSizeCode = value;
				}
			}

			public string ProductSizeName
			{
				get
				{
					return productSizeName;
				}
				set	
				{
					productSizeName = value;
				}
			}

			public string CaseCode
			{
				get
				{
					return caseCode;
				}
				set	
				{
					caseCode = value;
				}
			}

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string ProductColorCode
			{
				get
				{
					return productColorCode;
				}
				set	
				{
					productColorCode = value;
				}
			}

			public int? BoxQuantity
			{
				get
				{
					return boxQuantity;
				}
				set	
				{
					boxQuantity = value;
				}
			}
		}
	}
}
