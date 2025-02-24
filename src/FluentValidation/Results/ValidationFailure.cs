#region License
// Copyright (c) .NET Foundation and contributors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/FluentValidation/FluentValidation
#endregion

namespace FluentValidation.Results;

using System;
using System.Collections.Generic;

/// <summary>
/// Defines a validation failure
/// </summary>
[Serializable]
public class ValidationFailure {

	/// <summary>
	/// Creates a new validation failure.
	/// </summary>
	public ValidationFailure() {

	}

	/// <summary>
	/// Creates a new validation failure.
	/// </summary>
	public ValidationFailure(string propertyName, string errorMessage) : this(propertyName, errorMessage, null) {

	}

	/// <summary>
	/// Creates a new ValidationFailure.
	/// </summary>
	public ValidationFailure(string propertyName, string errorMessage, object attemptedValue) {
		PropertyName = propertyName;
		ErrorMessage = errorMessage;
		AttemptedValue = attemptedValue;
	}

	public ValidationFailure(string propertyName, string errorMessage, object attemptedValue, RuleMessageType? messageType) {
		PropertyName = propertyName;
		ErrorMessage = errorMessage;
		AttemptedValue = attemptedValue;
		MessageType = messageType;
	}

	/// <summary>
	/// The name of the property.
	/// </summary>
	public string PropertyName { get; set; }

	/// <summary>
	/// The error message
	/// </summary>
	public string ErrorMessage { get; set; }

	/// <summary>
	/// The property value that caused the failure.
	/// </summary>
	public object AttemptedValue { get; set; }

	/// <summary>
	/// Custom state associated with the failure.
	/// </summary>
	public object CustomState { get; set; }

	/// <summary>
	/// Custom severity level associated with the failure.
	/// </summary>
	public Severity Severity { get; set; } = Severity.Error;

	/// <summary>
	/// Gets or sets the error code.
	/// </summary>
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or sets the formatted message placeholder values.
	/// </summary>
	public Dictionary<string, object> FormattedMessagePlaceholderValues { get; set; }

	public RuleMessageType? MessageType { get; set; }

	/// <summary>
	/// Creates a textual representation of the failure.
	/// </summary>
	public override string ToString() {
		return ErrorMessage;
	}
}
