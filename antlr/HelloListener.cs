//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Hello.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ProjAntlr4Test.antlr {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="HelloParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface IHelloListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.start_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart_rule([NotNull] HelloParser.Start_ruleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.start_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart_rule([NotNull] HelloParser.Start_ruleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.sub_ents"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSub_ents([NotNull] HelloParser.Sub_entsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.sub_ents"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSub_ents([NotNull] HelloParser.Sub_entsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.fm_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFm_section([NotNull] HelloParser.Fm_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.fm_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFm_section([NotNull] HelloParser.Fm_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.fm_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFm_block([NotNull] HelloParser.Fm_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.fm_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFm_block([NotNull] HelloParser.Fm_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] HelloParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] HelloParser.BooleanContext context);
}
} // namespace ProjAntlr4Test.antlr
