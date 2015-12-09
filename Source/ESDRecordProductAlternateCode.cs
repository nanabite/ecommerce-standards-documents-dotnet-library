﻿/// <remarks>
/// Copyright (C) 2016 Squizz PTY LTD
/// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards Record that holds data for a single alternate code for a product. An alternate code is a different code that could be used to identify a product.</summary>
    [DataContract]
    public class ESDRecordProductAlternateCode
    {
        /// <summary>Key of the product record that the alternate code is assigned to.</summary>
        [DataMember]
        public string keyProductID { get; set; }
        /// <summary>Alternate code. May or may not be a unique identifier</summary>
        [DataMember]
        public string alternateCode { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the alternate code may be used to directly link to the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isUseCode { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the alternate code has been defined by another entity who supplies the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isSupplierCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}