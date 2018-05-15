﻿/*
 * Copyright 2017 Fireshark Studios, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Butterfly.Core.Database.Event {
    public enum TransactionState {
        Uncommitted,
        Committed,
    }

    /// <summary>
    /// Represents a series of <see cref="DataEvent"/> instances resulting either
    /// from an initial query or from committing an <see cref="IDatabase"/> transaction
    /// </summary>
    public class DataEventTransaction {
        public readonly DateTime dateTime;
        public readonly DataEvent[] dataEvents;

        protected readonly Dictionary<string, object> storage = new Dictionary<string, object>();

        public DataEventTransaction(DateTime dateTime, DataEvent[] dataEvents) {
            this.dateTime = dateTime;
            this.dataEvents = dataEvents;
        }

        public void Store(string key, object obj) => this.storage[key] = obj;

        public object Fetch(string key) {
            if (this.storage.TryGetValue(key, out object obj)) return obj;
            else return null;
        }

        public override string ToString() {
            return $"{{dateTime={dateTime},dataEvents={string.Join(";", (object[])dataEvents)}}}";
        }

        public static DataEventTransaction FilterDataEvents(DataEventTransaction dataEventTransaction, Func<DataEvent, bool> dataEventFilter) {
            return new DataEventTransaction(dataEventTransaction.dateTime, dataEventTransaction.dataEvents.Where(dataEventFilter).ToArray());
        }
    }
}