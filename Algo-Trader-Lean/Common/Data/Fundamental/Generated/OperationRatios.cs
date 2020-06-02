/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

// To get up to date fundamental definition files for your hedgefund contact sales@quantconnect.com

using System;
using System.IO;
using Newtonsoft.Json;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the OperationRatios class
	/// </summary>
	public class OperationRatios
	{
		/// <summary>
		/// The growth in the company's revenue on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying revenue data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10001
		/// </remarks>
		[JsonProperty("10001")]
		public RevenueGrowth RevenueGrowth { get; set; }

		/// <summary>
		/// The growth in the company's operating income on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying operating income data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10002
		/// </remarks>
		[JsonProperty("10002")]
		public OperationIncomeGrowth OperationIncomeGrowth { get; set; }

		/// <summary>
		/// The growth in the company's net income on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying net income data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10003
		/// </remarks>
		[JsonProperty("10003")]
		public NetIncomeGrowth NetIncomeGrowth { get; set; }

		/// <summary>
		/// The growth in the company's net income from continuing operations on a percentage basis. Morningstar calculates the growth
		/// percentage based on the underlying net income from continuing operations data reported in the Income Statement within the
		/// company filings or reports. This figure represents the rate of net income growth for parts of the business that will continue to
		/// generate revenue in the future.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10004
		/// </remarks>
		[JsonProperty("10004")]
		public NetIncomeContOpsGrowth NetIncomeContOpsGrowth { get; set; }

		/// <summary>
		/// The growth in the company's cash flow from operations on a percentage basis. Morningstar calculates the growth percentage
		/// based on the underlying cash flow from operations data reported in the Cash Flow Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10005
		/// </remarks>
		[JsonProperty("10005")]
		public CFOGrowth CFOGrowth { get; set; }

		/// <summary>
		/// The growth in the company's free cash flow on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying cash flow from operations and capital expenditures data reported in the Cash Flow Statement within the company filings
		/// or reports:   Free Cash Flow = Cash flow from operations - Capital Expenditures.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10006
		/// </remarks>
		[JsonProperty("10006")]
		public FCFGrowth FCFGrowth { get; set; }

		/// <summary>
		/// The growth in the company's operating revenue on a percentage basis. Morningstar calculates the growth percentage based on
		/// the underlying operating revenue data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10007
		/// </remarks>
		[JsonProperty("10007")]
		public OperationRevenueGrowth3MonthAvg OperationRevenueGrowth3MonthAvg { get; set; }

		/// <summary>
		/// Refers to the ratio of gross profit to revenue. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:   (Revenue - Cost of Goods Sold) / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11001
		/// </remarks>
		[JsonProperty("11001")]
		public GrossMargin GrossMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of operating income to revenue. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Operating Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11002
		/// </remarks>
		[JsonProperty("11002")]
		public OperationMargin OperationMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of pretax income to revenue. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Pretax Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11003
		/// </remarks>
		[JsonProperty("11003")]
		public PretaxMargin PretaxMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of net income to revenue. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:   Net Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11004
		/// </remarks>
		[JsonProperty("11004")]
		public NetMargin NetMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of tax provision to pretax income. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Tax Provision / Pretax Income.
		/// [Note: Valid only when positive pretax income, and positive tax expense (not tax benefit)]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11005
		/// </remarks>
		[JsonProperty("11005")]
		public TaxRate TaxRate { get; set; }

		/// <summary>
		/// Refers to the ratio of earnings before interest and taxes to revenue. Morningstar calculates the ratio by using the underlying data
		/// reported in the company filings or reports:   EBIT / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11006
		/// </remarks>
		[JsonProperty("11006")]
		public EBITMargin EBITMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of earnings before interest, taxes and depreciation and amortization to revenue. Morningstar calculates the ratio
		/// by using the underlying data reported in the company filings or reports:   EBITDA / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11007
		/// </remarks>
		[JsonProperty("11007")]
		public EBITDAMargin EBITDAMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of Revenue to Employees. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:     Revenue / Employee Number.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11008
		/// </remarks>
		[JsonProperty("11008")]
		public SalesPerEmployee SalesPerEmployee { get; set; }

		/// <summary>
		/// Refers to the ratio of Current Assets to Current Liabilities. Morningstar calculates the ratio by using the underlying data reported in
		/// the Balance Sheet within the company filings or reports:     Current Assets / Current Liabilities.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11009
		/// </remarks>
		[JsonProperty("11009")]
		public CurrentRatio CurrentRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of liquid assets to Current Liabilities. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:(Cash, Cash Equivalents, and Short Term Investments + Receivables ) /
		/// Current Liabilities.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11010
		/// </remarks>
		[JsonProperty("11010")]
		public QuickRatio QuickRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of Long Term Debt to Total Capital. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:    Long-Term Debt And Capital Lease Obligation / (Long-Term Debt And Capital
		/// Lease Obligation + Total Shareholder's Equity)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11011
		/// </remarks>
		[JsonProperty("11011")]
		public LongTermDebtTotalCapitalRatio LongTermDebtTotalCapitalRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of EBIT to Interest Expense. Morningstar calculates the ratio by using the underlying data reported in the Income
		/// Statement within the company filings or reports:    EBIT / Interest Expense.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11012
		/// </remarks>
		[JsonProperty("11012")]
		public InterestCoverage InterestCoverage { get; set; }

		/// <summary>
		/// Refers to the ratio of Long Term Debt to Common Equity. Morningstar calculates the ratio by using the underlying data reported in
		/// the Balance Sheet within the company filings or reports:    Long-Term Debt And Capital Lease Obligation / Common Equity.
		/// [Note: Common Equity = Total Shareholder's Equity - Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11013
		/// </remarks>
		[JsonProperty("11013")]
		public LongTermDebtEquityRatio LongTermDebtEquityRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of Total Assets to Common Equity. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:    Total Assets / Common Equity.   [Note: Common Equity = Total
		/// Shareholder's Equity - Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11014
		/// </remarks>
		[JsonProperty("11014")]
		public FinancialLeverage FinancialLeverage { get; set; }

		/// <summary>
		/// Refers to the ratio of Total Debt to Common Equity. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports: (Current Debt And Current Capital Lease Obligation + Long-Term Debt And
		/// Long-Term Capital Lease Obligation / Common Equity.   [Note: Common Equity = Total Shareholder's Equity - Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11015
		/// </remarks>
		[JsonProperty("11015")]
		public TotalDebtEquityRatio TotalDebtEquityRatio { get; set; }

		/// <summary>
		/// Normalized Income / Total Revenue. A measure of profitability of the company calculated by finding Normalized Net Profit as a
		/// percentage of Total Revenues.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11016
		/// </remarks>
		[JsonProperty("11016")]
		public NormalizedNetProfitMargin NormalizedNetProfitMargin { get; set; }

		/// <summary>
		/// 365 / Receivable Turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12001
		/// </remarks>
		[JsonProperty("12001")]
		public DaysInSales DaysInSales { get; set; }

		/// <summary>
		/// 365 / Inventory turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12002
		/// </remarks>
		[JsonProperty("12002")]
		public DaysInInventory DaysInInventory { get; set; }

		/// <summary>
		/// 365 / Payable turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12003
		/// </remarks>
		[JsonProperty("12003")]
		public DaysInPayment DaysInPayment { get; set; }

		/// <summary>
		/// Days In Inventory + Days In Sales - Days In Payment
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12004
		/// </remarks>
		[JsonProperty("12004")]
		public CashConversionCycle CashConversionCycle { get; set; }

		/// <summary>
		/// Revenue / Average Accounts Receivables
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12005
		/// </remarks>
		[JsonProperty("12005")]
		public ReceivableTurnover ReceivableTurnover { get; set; }

		/// <summary>
		/// Cost Of Goods Sold / Average Inventory
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12006
		/// </remarks>
		[JsonProperty("12006")]
		public InventoryTurnover InventoryTurnover { get; set; }

		/// <summary>
		/// Cost of Goods Sold / Average Accounts Payables
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12007
		/// </remarks>
		[JsonProperty("12007")]
		public PaymentTurnover PaymentTurnover { get; set; }

		/// <summary>
		/// Revenue / Average PP&amp;E
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12008
		/// </remarks>
		[JsonProperty("12008")]
		public FixAssetsTuronver FixAssetsTuronver { get; set; }

		/// <summary>
		/// Revenue / Average Total Assets
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12009
		/// </remarks>
		[JsonProperty("12009")]
		public AssetsTurnover AssetsTurnover { get; set; }

		/// <summary>
		/// Net Income / Average Total Common Equity
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12010
		/// </remarks>
		[JsonProperty("12010")]
		public ROE ROE { get; set; }

		/// <summary>
		/// Net Income / Average Total Assets
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12011
		/// </remarks>
		[JsonProperty("12011")]
		public ROA ROA { get; set; }

		/// <summary>
		/// Net Income / (Total Equity + Long-term Debt and Capital Lease Obligation + Short-term Debt and Capital Lease Obligation)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12012
		/// </remarks>
		[JsonProperty("12012")]
		public ROIC ROIC { get; set; }

		/// <summary>
		/// Free Cash flow / Revenue
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12013
		/// </remarks>
		[JsonProperty("12013")]
		public FCFSalesRatio FCFSalesRatio { get; set; }

		/// <summary>
		/// Free Cash Flow / Net Income
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12014
		/// </remarks>
		[JsonProperty("12014")]
		public FCFNetIncomeRatio FCFNetIncomeRatio { get; set; }

		/// <summary>
		/// Capital Expenditure / Revenue
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12015
		/// </remarks>
		[JsonProperty("12015")]
		public CapExSalesRatio CapExSalesRatio { get; set; }

		/// <summary>
		/// This is a leverage ratio used to determine how much debt (a sum of long term and current portion of debt) a company has on its
		/// balance sheet relative to total assets. This ratio examines the percent of the company that is financed by debt.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12016
		/// </remarks>
		[JsonProperty("12016")]
		public DebttoAssets DebttoAssets { get; set; }

		/// <summary>
		/// This is a financial ratio of common stock equity to total assets that indicates the relative proportion of equity used to finance a
		/// company's assets.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12017
		/// </remarks>
		[JsonProperty("12017")]
		public CommonEquityToAssets CommonEquityToAssets { get; set; }

		/// <summary>
		/// This is the compound annual growth rate of the company's capital spending over the last 5 years. Capital Spending is the sum of
		/// the Capital Expenditure items found in the Statement of Cash Flows.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12018
		/// </remarks>
		[JsonProperty("12018")]
		public CapitalExpenditureAnnual5YrGrowth CapitalExpenditureAnnual5YrGrowth { get; set; }

		/// <summary>
		/// This is the compound annual growth rate of the company's Gross Profit over the last 5 years.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12019
		/// </remarks>
		[JsonProperty("12019")]
		public GrossProfitAnnual5YrGrowth GrossProfitAnnual5YrGrowth { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Gross Margin over the last 5 years. Gross Margin is Total Revenue minus Cost
		/// of Goods Sold divided by Total Revenue and is expressed as a percentage.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12020
		/// </remarks>
		[JsonProperty("12020")]
		public GrossMargin5YrAvg GrossMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Post Tax Margin over the last 5 years. Post tax margin is Post tax divided by
		/// total revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12021
		/// </remarks>
		[JsonProperty("12021")]
		public PostTaxMargin5YrAvg PostTaxMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Pre Tax Margin over the last 5 years. Pre tax margin is Pre tax divided by total
		/// revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12022
		/// </remarks>
		[JsonProperty("12022")]
		public PreTaxMargin5YrAvg PreTaxMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Net Profit Margin over the last 5 years. Net profit margin is post tax income
		/// divided by total revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12023
		/// </remarks>
		[JsonProperty("12023")]
		public ProfitMargin5YrAvg ProfitMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROE over the last 5 years. Return on equity reveals how much profit a company has
		/// earned in comparison to the total amount of shareholder equity found on the balance sheet.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12024
		/// </remarks>
		[JsonProperty("12024")]
		public ROE5YrAvg ROE5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROA over the last 5 years. Return on asset is calculated by dividing a company's annual
		/// earnings by its average total assets.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12025
		/// </remarks>
		[JsonProperty("12025")]
		public ROA5YrAvg ROA5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROIC over the last 5 years. Return on invested capital is calculated by taking net
		/// operating profit after taxes and dividends and dividing by the total amount of capital invested and expressing the result as a
		/// percentage.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12026
		/// </remarks>
		[JsonProperty("12026")]
		public AVG5YrsROIC AVG5YrsROIC { get; set; }

		/// <summary>
		/// [Normalized Income + (Interest Expense * (1-Tax Rate))]  / Invested Capital
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12027
		/// </remarks>
		[JsonProperty("12027")]
		public NormalizedROIC NormalizedROIC { get; set; }

		/// <summary>
		/// The five-year growth rate of operating revenue, calculated using regression analysis.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12028
		/// </remarks>
		[JsonProperty("12028")]
		public RegressionGrowthOperatingRevenue5Years RegressionGrowthOperatingRevenue5Years { get; set; }

		/// <summary>
		/// Indicates a company's short-term liquidity, defined as short term liquid investments (cash, cash equivalents, short term
		/// investments) divided by current liabilities.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12029
		/// </remarks>
		[JsonProperty("12029")]
		public CashRatio CashRatio { get; set; }

		/// <summary>
		/// Represents the percentage of a company's total assets is in cash.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12030
		/// </remarks>
		[JsonProperty("12030")]
		public CashtoTotalAssets CashtoTotalAssets { get; set; }

		/// <summary>
		/// Measures the amount a company is investing in its business relative to EBITDA generated in a given period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12031
		/// </remarks>
		[JsonProperty("12031")]
		public CapitalExpendituretoEBITDA CapitalExpendituretoEBITDA { get; set; }

		/// <summary>
		/// Indicates the percentage of a company's operating cash flow is free to be invested in its business after capital expenditures.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12032
		/// </remarks>
		[JsonProperty("12032")]
		public FCFtoCFO FCFtoCFO { get; set; }

		/// <summary>
		/// The growth in the stockholder's equity on a percentage basis. Morningstar calculates the growth percentage based on the residual
		/// interest in the assets of the enterprise that remains after deducting its liabilities reported in the Balance Sheet within the company
		/// filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12033
		/// </remarks>
		[JsonProperty("12033")]
		public StockholdersEquityGrowth StockholdersEquityGrowth { get; set; }

		/// <summary>
		/// The growth in the total assets on a percentage basis. Morningstar calculates the growth percentage based on the total assets
		/// reported in the Balance Sheet within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12034
		/// </remarks>
		[JsonProperty("12034")]
		public TotalAssetsGrowth TotalAssetsGrowth { get; set; }

		/// <summary>
		/// The growth in the total liabilities on a percentage basis. Morningstar calculates the growth percentage based on the total liabilities
		/// reported in the Balance Sheet within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12035
		/// </remarks>
		[JsonProperty("12035")]
		public TotalLiabilitiesGrowth TotalLiabilitiesGrowth { get; set; }

		/// <summary>
		/// The growth in the company's total debt to equity ratio on a percentage basis. Morningstar calculates the growth percentage based
		/// on the total debt divided by the shareholder's equity reported in the Balance Sheet within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12036
		/// </remarks>
		[JsonProperty("12036")]
		public TotalDebtEquityRatioGrowth TotalDebtEquityRatioGrowth { get; set; }

		/// <summary>
		/// The growth in the company's cash ratio on a percentage basis. Morningstar calculates the growth percentage based on the short
		/// term liquid investments (cash, cash equivalents, short term investments) divided by current liabilities reported in the Balance Sheet
		/// within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12037
		/// </remarks>
		[JsonProperty("12037")]
		public CashRatioGrowth CashRatioGrowth { get; set; }

		/// <summary>
		/// The growth in the company's EBITDA on a percentage basis. Morningstar calculates the growth percentage based on the earnings
		/// minus expenses (excluding interest, tax, depreciation, and amortization expenses) reported in the Financial Statements within the
		/// company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12038
		/// </remarks>
		[JsonProperty("12038")]
		public EBITDAGrowth EBITDAGrowth { get; set; }

		/// <summary>
		/// The growth in the company's cash flows from financing on a percentage basis. Morningstar calculates the growth percentage
		/// based on the financing cash flows reported in the Cash Flow Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12039
		/// </remarks>
		[JsonProperty("12039")]
		public CashFlowfromFinancingGrowth CashFlowfromFinancingGrowth { get; set; }

		/// <summary>
		/// The growth in the company's cash flows from investing on a percentage basis. Morningstar calculates the growth percentage
		/// based on the cash flows from investing reported in the Cash Flow Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12040
		/// </remarks>
		[JsonProperty("12040")]
		public CashFlowfromInvestingGrowth CashFlowfromInvestingGrowth { get; set; }

		/// <summary>
		/// The growth in the company's capital expenditures on a percentage basis. Morningstar calculates the growth percentage based on
		/// the capital expenditures reported in the Cash Flow Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12041
		/// </remarks>
		[JsonProperty("12041")]
		public CapExGrowth CapExGrowth { get; set; }

		/// <summary>
		/// The growth in the company's current ratio on a percentage basis. Morningstar calculates the growth percentage based on the
		/// current assets divided by current liabilities reported in the Balance Sheet within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12042
		/// </remarks>
		[JsonProperty("12042")]
		public CurrentRatioGrowth CurrentRatioGrowth { get; set; }

		/// <summary>
		/// Total revenue / working capital (current assets minus current liabilities)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12043
		/// </remarks>
		[JsonProperty("12043")]
		public WorkingCapitalTurnoverRatio WorkingCapitalTurnoverRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of Net Income to Employees. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:     Net Income / Employee Number.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12044
		/// </remarks>
		[JsonProperty("12044")]
		public NetIncomePerEmployee NetIncomePerEmployee { get; set; }

		/// <summary>
		/// Measure of whether a company's cash flow is sufficient to meet its short-term and long-term debt requirements. The lower this
		/// ratio is, the greater the probability that the company will be in financial distress. Net Income + Depreciation, Depletion and
		/// Amortization/ average of annual Total Liabilities over the most recent two periods.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12045
		/// </remarks>
		[JsonProperty("12045")]
		public SolvencyRatio SolvencyRatio { get; set; }

		/// <summary>
		/// A measure of operating performance for Insurance companies, as it shows the relationship between the premiums earned and
		/// administrative expenses related to claims such as fees and commissions. A number of 1 or lower is preferred, as this means the
		/// premiums exceed the expenses. Calculated as: (Deferred Policy Acquisition Amortization Expense+Fees and Commission
		/// Expense+Other Underwriting Expenses+Selling, General and Administrative) / Net Premiums Earned
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12046
		/// </remarks>
		[JsonProperty("12046")]
		public ExpenseRatio ExpenseRatio { get; set; }

		/// <summary>
		/// A measure of operating performance for Insurance companies, as it shows the relationship between the premiums earned and the
		/// expenses related to claims. A number of 1 or lower is preferred, as this means the premiums exceed the expenses. Calculated as:
		/// Benefits, Claims and Loss Adjustment Expense, Net / Net Premiums Earned
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12047
		/// </remarks>
		[JsonProperty("12047")]
		public LossRatio LossRatio { get; set; }

		/// <summary>
		/// Creates an instance of the OperationRatios class
		/// </summary>
		public OperationRatios()
		{
			RevenueGrowth = new RevenueGrowth();
			OperationIncomeGrowth = new OperationIncomeGrowth();
			NetIncomeGrowth = new NetIncomeGrowth();
			NetIncomeContOpsGrowth = new NetIncomeContOpsGrowth();
			CFOGrowth = new CFOGrowth();
			FCFGrowth = new FCFGrowth();
			OperationRevenueGrowth3MonthAvg = new OperationRevenueGrowth3MonthAvg();
			GrossMargin = new GrossMargin();
			OperationMargin = new OperationMargin();
			PretaxMargin = new PretaxMargin();
			NetMargin = new NetMargin();
			TaxRate = new TaxRate();
			EBITMargin = new EBITMargin();
			EBITDAMargin = new EBITDAMargin();
			SalesPerEmployee = new SalesPerEmployee();
			CurrentRatio = new CurrentRatio();
			QuickRatio = new QuickRatio();
			LongTermDebtTotalCapitalRatio = new LongTermDebtTotalCapitalRatio();
			InterestCoverage = new InterestCoverage();
			LongTermDebtEquityRatio = new LongTermDebtEquityRatio();
			FinancialLeverage = new FinancialLeverage();
			TotalDebtEquityRatio = new TotalDebtEquityRatio();
			NormalizedNetProfitMargin = new NormalizedNetProfitMargin();
			DaysInSales = new DaysInSales();
			DaysInInventory = new DaysInInventory();
			DaysInPayment = new DaysInPayment();
			CashConversionCycle = new CashConversionCycle();
			ReceivableTurnover = new ReceivableTurnover();
			InventoryTurnover = new InventoryTurnover();
			PaymentTurnover = new PaymentTurnover();
			FixAssetsTuronver = new FixAssetsTuronver();
			AssetsTurnover = new AssetsTurnover();
			ROE = new ROE();
			ROA = new ROA();
			ROIC = new ROIC();
			FCFSalesRatio = new FCFSalesRatio();
			FCFNetIncomeRatio = new FCFNetIncomeRatio();
			CapExSalesRatio = new CapExSalesRatio();
			DebttoAssets = new DebttoAssets();
			CommonEquityToAssets = new CommonEquityToAssets();
			CapitalExpenditureAnnual5YrGrowth = new CapitalExpenditureAnnual5YrGrowth();
			GrossProfitAnnual5YrGrowth = new GrossProfitAnnual5YrGrowth();
			GrossMargin5YrAvg = new GrossMargin5YrAvg();
			PostTaxMargin5YrAvg = new PostTaxMargin5YrAvg();
			PreTaxMargin5YrAvg = new PreTaxMargin5YrAvg();
			ProfitMargin5YrAvg = new ProfitMargin5YrAvg();
			ROE5YrAvg = new ROE5YrAvg();
			ROA5YrAvg = new ROA5YrAvg();
			AVG5YrsROIC = new AVG5YrsROIC();
			NormalizedROIC = new NormalizedROIC();
			RegressionGrowthOperatingRevenue5Years = new RegressionGrowthOperatingRevenue5Years();
			CashRatio = new CashRatio();
			CashtoTotalAssets = new CashtoTotalAssets();
			CapitalExpendituretoEBITDA = new CapitalExpendituretoEBITDA();
			FCFtoCFO = new FCFtoCFO();
			StockholdersEquityGrowth = new StockholdersEquityGrowth();
			TotalAssetsGrowth = new TotalAssetsGrowth();
			TotalLiabilitiesGrowth = new TotalLiabilitiesGrowth();
			TotalDebtEquityRatioGrowth = new TotalDebtEquityRatioGrowth();
			CashRatioGrowth = new CashRatioGrowth();
			EBITDAGrowth = new EBITDAGrowth();
			CashFlowfromFinancingGrowth = new CashFlowfromFinancingGrowth();
			CashFlowfromInvestingGrowth = new CashFlowfromInvestingGrowth();
			CapExGrowth = new CapExGrowth();
			CurrentRatioGrowth = new CurrentRatioGrowth();
			WorkingCapitalTurnoverRatio = new WorkingCapitalTurnoverRatio();
			NetIncomePerEmployee = new NetIncomePerEmployee();
			SolvencyRatio = new SolvencyRatio();
			ExpenseRatio = new ExpenseRatio();
			LossRatio = new LossRatio();
		}

		/// <summary>
		/// Applies updated values from <paramref name="update"/> to this instance
		/// </summary>
		/// <remarks>Used to apply data updates to the current instance. This WILL overwrite existing values. Default update values are ignored.</remarks>
		/// <param name="update">The next data update for this instance</param>
		public void UpdateValues(OperationRatios update)
		{
			if (update == null) return;

			RevenueGrowth?.UpdateValues(update.RevenueGrowth);
			OperationIncomeGrowth?.UpdateValues(update.OperationIncomeGrowth);
			NetIncomeGrowth?.UpdateValues(update.NetIncomeGrowth);
			NetIncomeContOpsGrowth?.UpdateValues(update.NetIncomeContOpsGrowth);
			CFOGrowth?.UpdateValues(update.CFOGrowth);
			FCFGrowth?.UpdateValues(update.FCFGrowth);
			OperationRevenueGrowth3MonthAvg?.UpdateValues(update.OperationRevenueGrowth3MonthAvg);
			GrossMargin?.UpdateValues(update.GrossMargin);
			OperationMargin?.UpdateValues(update.OperationMargin);
			PretaxMargin?.UpdateValues(update.PretaxMargin);
			NetMargin?.UpdateValues(update.NetMargin);
			TaxRate?.UpdateValues(update.TaxRate);
			EBITMargin?.UpdateValues(update.EBITMargin);
			EBITDAMargin?.UpdateValues(update.EBITDAMargin);
			SalesPerEmployee?.UpdateValues(update.SalesPerEmployee);
			CurrentRatio?.UpdateValues(update.CurrentRatio);
			QuickRatio?.UpdateValues(update.QuickRatio);
			LongTermDebtTotalCapitalRatio?.UpdateValues(update.LongTermDebtTotalCapitalRatio);
			InterestCoverage?.UpdateValues(update.InterestCoverage);
			LongTermDebtEquityRatio?.UpdateValues(update.LongTermDebtEquityRatio);
			FinancialLeverage?.UpdateValues(update.FinancialLeverage);
			TotalDebtEquityRatio?.UpdateValues(update.TotalDebtEquityRatio);
			NormalizedNetProfitMargin?.UpdateValues(update.NormalizedNetProfitMargin);
			DaysInSales?.UpdateValues(update.DaysInSales);
			DaysInInventory?.UpdateValues(update.DaysInInventory);
			DaysInPayment?.UpdateValues(update.DaysInPayment);
			CashConversionCycle?.UpdateValues(update.CashConversionCycle);
			ReceivableTurnover?.UpdateValues(update.ReceivableTurnover);
			InventoryTurnover?.UpdateValues(update.InventoryTurnover);
			PaymentTurnover?.UpdateValues(update.PaymentTurnover);
			FixAssetsTuronver?.UpdateValues(update.FixAssetsTuronver);
			AssetsTurnover?.UpdateValues(update.AssetsTurnover);
			ROE?.UpdateValues(update.ROE);
			ROA?.UpdateValues(update.ROA);
			ROIC?.UpdateValues(update.ROIC);
			FCFSalesRatio?.UpdateValues(update.FCFSalesRatio);
			FCFNetIncomeRatio?.UpdateValues(update.FCFNetIncomeRatio);
			CapExSalesRatio?.UpdateValues(update.CapExSalesRatio);
			DebttoAssets?.UpdateValues(update.DebttoAssets);
			CommonEquityToAssets?.UpdateValues(update.CommonEquityToAssets);
			CapitalExpenditureAnnual5YrGrowth?.UpdateValues(update.CapitalExpenditureAnnual5YrGrowth);
			GrossProfitAnnual5YrGrowth?.UpdateValues(update.GrossProfitAnnual5YrGrowth);
			GrossMargin5YrAvg?.UpdateValues(update.GrossMargin5YrAvg);
			PostTaxMargin5YrAvg?.UpdateValues(update.PostTaxMargin5YrAvg);
			PreTaxMargin5YrAvg?.UpdateValues(update.PreTaxMargin5YrAvg);
			ProfitMargin5YrAvg?.UpdateValues(update.ProfitMargin5YrAvg);
			ROE5YrAvg?.UpdateValues(update.ROE5YrAvg);
			ROA5YrAvg?.UpdateValues(update.ROA5YrAvg);
			AVG5YrsROIC?.UpdateValues(update.AVG5YrsROIC);
			NormalizedROIC?.UpdateValues(update.NormalizedROIC);
			RegressionGrowthOperatingRevenue5Years?.UpdateValues(update.RegressionGrowthOperatingRevenue5Years);
			CashRatio?.UpdateValues(update.CashRatio);
			CashtoTotalAssets?.UpdateValues(update.CashtoTotalAssets);
			CapitalExpendituretoEBITDA?.UpdateValues(update.CapitalExpendituretoEBITDA);
			FCFtoCFO?.UpdateValues(update.FCFtoCFO);
			StockholdersEquityGrowth?.UpdateValues(update.StockholdersEquityGrowth);
			TotalAssetsGrowth?.UpdateValues(update.TotalAssetsGrowth);
			TotalLiabilitiesGrowth?.UpdateValues(update.TotalLiabilitiesGrowth);
			TotalDebtEquityRatioGrowth?.UpdateValues(update.TotalDebtEquityRatioGrowth);
			CashRatioGrowth?.UpdateValues(update.CashRatioGrowth);
			EBITDAGrowth?.UpdateValues(update.EBITDAGrowth);
			CashFlowfromFinancingGrowth?.UpdateValues(update.CashFlowfromFinancingGrowth);
			CashFlowfromInvestingGrowth?.UpdateValues(update.CashFlowfromInvestingGrowth);
			CapExGrowth?.UpdateValues(update.CapExGrowth);
			CurrentRatioGrowth?.UpdateValues(update.CurrentRatioGrowth);
			WorkingCapitalTurnoverRatio?.UpdateValues(update.WorkingCapitalTurnoverRatio);
			NetIncomePerEmployee?.UpdateValues(update.NetIncomePerEmployee);
			SolvencyRatio?.UpdateValues(update.SolvencyRatio);
			ExpenseRatio?.UpdateValues(update.ExpenseRatio);
			LossRatio?.UpdateValues(update.LossRatio);
		}
	}
}