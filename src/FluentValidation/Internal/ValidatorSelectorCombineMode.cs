using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidation.Internal;

/// <summary>
/// Specifies how to combine results of validator selectors for <see cref="CompositeValidatorSelector" />
/// </summary>
public enum ValidatorSelectorCombineMode {
	/// <summary>
	/// A validator is allowed to run only when <c>All</c> validator selectors return true from <see cref="IValidatorSelector.CanExecute"/>
	/// </summary>
	/// <example>
	/// When using <c>All</c> a validator will be executed only when all rulesets, properties and custom <see cref="IValidatorSelector"/> match those defined in a <see cref="ValidationStrategy{T}"/>
	/// </example>
	All,
	/// <summary>
	/// A validator is allowed to run when <c>Any</c> (default) of validator selectors return true from <see cref="IValidatorSelector.CanExecute"/>
	/// </summary>
	/// <example>
	/// When using <c>Any</c> a validator will be executed when either rulesets or a property or a custom <see cref="IValidatorSelector"/> match those defined in a <see cref="ValidationStrategy{T}"/>
	/// </example>
	/// <remarks>
	/// This is a default value
	/// </remarks>
	Any,
}
