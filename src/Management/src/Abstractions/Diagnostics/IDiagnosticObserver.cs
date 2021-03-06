﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Steeltoe.Common.Diagnostics
{
    public interface IDiagnosticObserver : IObserver<KeyValuePair<string, object>>
    {
        string ObserverName { get; }

        string ListenerName { get; }

        void Subscribe(DiagnosticListener listener);

        // TODO: Address this warning in 3.0 ?
#pragma warning disable S2953 // Methods named "Dispose" should implement "IDisposable.Dispose"
        void Dispose();
#pragma warning restore S2953 // Methods named "Dispose" should implement "IDisposable.Dispose"

        void ProcessEvent(string @event, object value);
    }
}
