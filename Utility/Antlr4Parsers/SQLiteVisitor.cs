//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\C#\VS2012\MasudaManager\MasudaManager\MasudaManager\Grammars\SQLite.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace MasudaManager {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SQLiteParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface ISQLiteVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_sequence_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_sequence_stmt([NotNull] SQLiteParser.Drop_sequence_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType_name([NotNull] SQLiteParser.Type_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_index_stmt([NotNull] SQLiteParser.Drop_index_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_name([NotNull] SQLiteParser.Table_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral_value([NotNull] SQLiteParser.Literal_valueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.disconnect_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisconnect_stmt([NotNull] SQLiteParser.Disconnect_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_def([NotNull] SQLiteParser.Column_defContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.new_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNew_table_name([NotNull] SQLiteParser.New_table_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyword([NotNull] SQLiteParser.KeywordContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.cmd_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_stmt([NotNull] SQLiteParser.Cmd_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitError_message([NotNull] SQLiteParser.Error_messageContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_operator([NotNull] SQLiteParser.Join_operatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollation_name([NotNull] SQLiteParser.Collation_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_alias([NotNull] SQLiteParser.Column_aliasContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] SQLiteParser.NameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule_name([NotNull] SQLiteParser.Module_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_alias([NotNull] SQLiteParser.Table_aliasContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_trigger_stmt([NotNull] SQLiteParser.Drop_trigger_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule_argument([NotNull] SQLiteParser.Module_argumentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSigned_number([NotNull] SQLiteParser.Signed_numberContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrdering_term([NotNull] SQLiteParser.Ordering_termContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.error"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitError([NotNull] SQLiteParser.ErrorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.select_or_values"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_or_values([NotNull] SQLiteParser.Select_or_valuesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_core([NotNull] SQLiteParser.Select_coreContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAny_name([NotNull] SQLiteParser.Any_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_table_stmt([NotNull] SQLiteParser.Drop_table_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] SQLiteParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_view_stmt([NotNull] SQLiteParser.Drop_view_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex_name([NotNull] SQLiteParser.Index_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitView_name([NotNull] SQLiteParser.View_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_sequence_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_sequence_stmt([NotNull] SQLiteParser.Create_sequence_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.cmd_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_stmt_list([NotNull] SQLiteParser.Cmd_stmt_listContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWith_clause([NotNull] SQLiteParser.With_clauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.database_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatabase_name([NotNull] SQLiteParser.Database_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.connect_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConnect_stmt([NotNull] SQLiteParser.Connect_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_name([NotNull] SQLiteParser.Column_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult_column([NotNull] SQLiteParser.Result_columnContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse([NotNull] SQLiteParser.ParseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_constraint([NotNull] SQLiteParser.Table_constraintContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_name([NotNull] SQLiteParser.Pragma_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeign_table([NotNull] SQLiteParser.Foreign_tableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_name([NotNull] SQLiteParser.Function_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_clause([NotNull] SQLiteParser.Join_clauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRaise_function([NotNull] SQLiteParser.Raise_functionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_value([NotNull] SQLiteParser.Pragma_valueContext context);
}
} // namespace MasudaManager
