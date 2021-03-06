﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
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
using System.Linq;
using System.Text;

namespace s2industries.ZUGFeRD
{
    public class Tax
    {
        public decimal TaxAmount {
            get
            {
                return 0.01m * this.Percent * this.BasisAmount;
            }
        }
        public decimal BasisAmount { get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        public decimal Percent { get; set; }
        public TaxTypes TypeCode { get; set; }
        public TaxCategoryCodes CategoryCode { get; set; }

        /// <summary>
        /// Gesamtbetrag Zu- und Abschläge des Steuersatzes, Wert
        /// </summary>
        public decimal AllowanceChargeBasisAmount { get; set; }


        public Tax()
        {
            this.CategoryCode = TaxCategoryCodes.S;
        }
    }
}
