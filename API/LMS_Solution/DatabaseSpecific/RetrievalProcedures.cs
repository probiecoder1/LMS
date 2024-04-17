﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace LMS.Application.LLBL.DatabaseSpecific
{
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{

		/// <summary>Calls stored procedure 'SpAllUserPersonSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpAllUserPersonSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpAllUserPersonSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpAllUserPersonSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpAllUserPersonSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpAllUserPersonSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpAllUserPersonSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpAllUserPersonSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpAllUserPersonSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpAllUserPersonSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpAllUserPersonSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpAllUserPersonSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpBookSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpBookSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpBookSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpBookSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpBookSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpBookSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpBookSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpBookSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpBookSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpBookSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpBookSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpBookSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpBorrowSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpBorrowSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpBorrowSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpBorrowSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpBorrowSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpBorrowSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpBorrowSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpBorrowSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpBorrowSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpBorrowSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpBorrowSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpBorrowSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpCustomerMembershipSel'.<br/><br/></summary>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpCustomerMembershipSel(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpCustomerMembershipSel(json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpCustomerMembershipSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpCustomerMembershipSel(System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpCustomerMembershipSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpCustomerMembershipSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpCustomerMembershipSelCallAsQuery(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpCustomerMembershipSelCallAsQuery(json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpCustomerMembershipSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpCustomerMembershipSelCallAsQuery(System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpCustomerMembershipSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpMemberSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpMemberSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpMemberSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpMemberSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpMemberSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpMemberSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpMemberSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpMemberSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpMemberSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpMemberSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpMemberSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpMemberSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpPaymentSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpPaymentSel(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpPaymentSel(json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpPaymentSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpPaymentSel(System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpPaymentSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpPaymentSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpPaymentSelCallAsQuery(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpPaymentSelCallAsQuery(json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpPaymentSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpPaymentSelCallAsQuery(System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpPaymentSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpRecentBookSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpRecentBookSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpRecentBookSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpRecentBookSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpRecentBookSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpRecentBookSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpRecentBookSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpRecentBookSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpRecentBookSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpRecentBookSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpRecentBookSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpRecentBookSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpTotalSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpTotalSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpTotalSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpTotalSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpTotalSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpTotalSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpTotalSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpTotalSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpTotalSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpTotalSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpTotalSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpTotalSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserDataSel'.<br/><br/></summary>
		/// <param name="jsonParams">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserDataSel(System.String jsonParams)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserDataSel(jsonParams, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserDataSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonParams">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserDataSel(System.String jsonParams, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserDataSelCall(dataAccessProvider, jsonParams))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserDataSel'.</summary>
		/// <param name="jsonParams">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserDataSelCallAsQuery(System.String jsonParams)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserDataSelCallAsQuery(jsonParams, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserDataSel'.</summary>
		/// <param name="jsonParams">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserDataSelCallAsQuery(System.String jsonParams, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserDataSelCall(dataAccessProvider, jsonParams).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserLoginSel'.<br/><br/></summary>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserLoginSel(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserLoginSel(json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserLoginSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserLoginSel(System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserLoginSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserLoginSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserLoginSelCallAsQuery(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserLoginSelCallAsQuery(json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserLoginSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserLoginSelCallAsQuery(System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserLoginSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserPaymentDetailsSel'.<br/><br/></summary>
		/// <param name="jsonParams">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserPaymentDetailsSel(System.String jsonParams)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserPaymentDetailsSel(jsonParams, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserPaymentDetailsSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonParams">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserPaymentDetailsSel(System.String jsonParams, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserPaymentDetailsSelCall(dataAccessProvider, jsonParams))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPaymentDetailsSel'.</summary>
		/// <param name="jsonParams">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPaymentDetailsSelCallAsQuery(System.String jsonParams)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserPaymentDetailsSelCallAsQuery(jsonParams, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPaymentDetailsSel'.</summary>
		/// <param name="jsonParams">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPaymentDetailsSelCallAsQuery(System.String jsonParams, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserPaymentDetailsSelCall(dataAccessProvider, jsonParams).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserPersonLoginSel'.<br/><br/></summary>
		/// <param name="jsonInput">Input parameter. </param>
		/// <returns>Filled DataSet with resultset(s) of stored procedure</returns>
		public static DataSet SpUserPersonLoginSel(System.String jsonInput)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserPersonLoginSel(jsonInput, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserPersonLoginSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonInput">Input parameter. </param>
		/// <returns>Filled DataSet with resultset(s) of stored procedure</returns>
		public static DataSet SpUserPersonLoginSel(System.String jsonInput, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserPersonLoginSelCall(dataAccessProvider, jsonInput))
			{
				DataSet toReturn = call.FillDataSet();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPersonLoginSel'.</summary>
		/// <param name="jsonInput">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPersonLoginSelCallAsQuery(System.String jsonInput)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserPersonLoginSelCallAsQuery(jsonInput, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPersonLoginSel'.</summary>
		/// <param name="jsonInput">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPersonLoginSelCallAsQuery(System.String jsonInput, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserPersonLoginSelCall(dataAccessProvider, jsonInput).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserPersonSel'.<br/><br/></summary>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserPersonSel(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserPersonSel(ref json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserPersonSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SpUserPersonSel(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserPersonSelCall(dataAccessProvider, json))
			{
				DataTable toReturn = call.FillDataTable();
				json = call.GetParameterValue<System.String>(0);
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPersonSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPersonSelCallAsQuery(ref System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserPersonSelCallAsQuery(ref json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserPersonSel'.</summary>
		/// <param name="json">InputOutput parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserPersonSelCallAsQuery(ref System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserPersonSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'SpUserSel'.<br/><br/></summary>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataSet with resultset(s) of stored procedure</returns>
		public static DataSet SpUserSel(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return SpUserSel(json, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'SpUserSel'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter. </param>
		/// <returns>Filled DataSet with resultset(s) of stored procedure</returns>
		public static DataSet SpUserSel(System.String json, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSpUserSelCall(dataAccessProvider, json))
			{
				DataSet toReturn = call.FillDataSet();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserSelCallAsQuery(System.String json)
		{
			using(var dataAccessProvider = new DataAccessAdapter())
			{
				return GetSpUserSelCallAsQuery(json, dataAccessProvider);
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'SpUserSel'.</summary>
		/// <param name="json">Input parameter of stored procedure</param>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSpUserSelCallAsQuery(System.String json, IDataAccessCore dataAccessProvider)
		{
			return CreateSpUserSelCall(dataAccessProvider, json).ToRetrievalQuery();
		}

		/// <summary>Creates the call object for the call 'SpAllUserPersonSel' to stored procedure 'SpAllUserPersonSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpAllUserPersonSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpAllUserPersonSel]", "SpAllUserPersonSel")
							.AddParameter("@Json", "VarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpBookSel' to stored procedure 'SpBookSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpBookSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpBookSel]", "SpBookSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpBorrowSel' to stored procedure 'SpBorrowSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpBorrowSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpBorrowSel]", "SpBorrowSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpCustomerMembershipSel' to stored procedure 'SpCustomerMembershipSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpCustomerMembershipSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpCustomerMembershipSel]", "SpCustomerMembershipSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpMemberSel' to stored procedure 'SpMemberSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpMemberSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpMemberSel]", "SpMemberSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpPaymentSel' to stored procedure 'SpPaymentSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpPaymentSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpPaymentSel]", "SpPaymentSel")
							.AddParameter("@Json", "VarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpRecentBookSel' to stored procedure 'SpRecentBookSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpRecentBookSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpRecentBookSel]", "SpRecentBookSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpTotalSel' to stored procedure 'SpTotalSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpTotalSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpTotalSel]", "SpTotalSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpUserDataSel' to stored procedure 'SpUserDataSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonParams">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserDataSelCall(IDataAccessCore dataAccessProvider, System.String jsonParams)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserDataSel]", "SpUserDataSel")
							.AddParameter("@JsonParams", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, jsonParams);
		}

		/// <summary>Creates the call object for the call 'SpUserLoginSel' to stored procedure 'SpUserLoginSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserLoginSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserLoginSel]", "SpUserLoginSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpUserPaymentDetailsSel' to stored procedure 'SpUserPaymentDetailsSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonParams">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserPaymentDetailsSelCall(IDataAccessCore dataAccessProvider, System.String jsonParams)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserPaymentDetailsSel]", "SpUserPaymentDetailsSel")
							.AddParameter("@JsonParams", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, jsonParams);
		}

		/// <summary>Creates the call object for the call 'SpUserPersonLoginSel' to stored procedure 'SpUserPersonLoginSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="jsonInput">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserPersonLoginSelCall(IDataAccessCore dataAccessProvider, System.String jsonInput)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserPersonLoginSel]", "SpUserPersonLoginSel")
							.AddParameter("@JsonInput", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, jsonInput);
		}

		/// <summary>Creates the call object for the call 'SpUserPersonSel' to stored procedure 'SpUserPersonSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserPersonSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserPersonSel]", "SpUserPersonSel")
							.AddParameter("@Json", "VarChar", 2147483647, ParameterDirection.InputOutput, true, 0, 0, json);
		}

		/// <summary>Creates the call object for the call 'SpUserSel' to stored procedure 'SpUserSel'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="json">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSpUserSelCall(IDataAccessCore dataAccessProvider, System.String json)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Roshish_LibraryManagementSystem].[dbo].[SpUserSel]", "SpUserSel")
							.AddParameter("@Json", "NVarChar", 2147483647, ParameterDirection.Input, true, 0, 0, json);
		}


	}
}