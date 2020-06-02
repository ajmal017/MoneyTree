from dataclasses import dataclass
from dataclasses_json import dataclass_json
from typing import List
from enum import Enum
import datetime
import pandas as pd

### Dataclasses used internally for generating portfolios and risk calculations ###
@dataclass()
class Asset():
    Ticker: str #asset ticker symbol
    Name: str #full name
    AssetType: str # type of asset stocks, bonds, crypto ..
    PriceHistoryFile: str #absolute path location of CSV file with historical data of stock
    LastPrice: float # latest price of asset, used for generating portfolio to ensure correct allocation
    AssetData: pd.DataFrame

@dataclass
class Universe():
    count: int
    UniverseSet: List[Asset]
    UniverseStartDate: str
    UniverseEndDate: str

@dataclass()
class Portfolio():
    UserID: int    # unique identifier for user to know who's portfolio it is
    BuyingPower: float # Money available for this user that has not being invested yet
    assets: List[Asset] # a list of stocks in this portfolio
    AssetAlloc: dict # weight distribution each asset in the portfolio
    AssetShares: dict # number of shares of each asset in the portfolio

### User Database data classes for messaging ###
class UDRequestType(Enum):
    Holding = 0
    Portfolio = 1
    PortfolioHistory = 2
    User = 3

class UDOperation(Enum):
    Insert = 0
    Read = 1
    Update = 2
    Delete = 3

class Risk(Enum):
    Low = 0
    Med = 1
    High = 2

@dataclass_json()
@dataclass()
class UDMHolding():
    Id: int             # unique ID
    PortfolioId: int
    Name: str           # full name of asset
    Abbreviation: str   # ticker
    Description: str    # notes on asset
    Quantity: int       # number of assets currently owned of this asset

@dataclass_json()
@dataclass()
class UDMPortfolio():
    Id: int             # unique ID
    OwnerId: int
    Active: bool        # portfolio live or not in use
    Generated: str    # date portfolio was generated by portfolio generator
    InitialValue: float # initial total value of portfolio
    StopValue: float
    DesiredRisk: Risk   # low,medium, or high
    Holding: List[UDMHolding]   # list of assets in portfolio

@dataclass_json()
@dataclass()
class UDMPortfolioHistory():
    Id: int             # unique id
    PortfolioId: int
    Date: str  # date of instance
    Valuation: float         # value of portfolio
    Risk: float             # low, medium, or high
    ActionTakenId: int      # buy, sell, hold ...

@dataclass_json()
@dataclass()
class UDMUser():
    Email: str
    FirstName: str
    LastName: str
    BrokerageAccount: str

@dataclass_json()
@dataclass()
class UDMRequest():
    Email: str
    objectID: int
    RequestType: UDRequestType      # request info for database
    Operation: UDOperation          # database operation for this portfolio
    Holding: UDMHolding
    Portfolio: List[UDMPortfolio]   # list of portfolios to go in request
    PortfolioHistory: List[List[UDMPortfolioHistory]]
    User: UDMUser                   # User these portfolios are for

#### Portfolio generator data classes for messaging ######
class PGRequestType(Enum):
    Generate = 0
    BackTestResults = 1

@dataclass_json()
@dataclass()
class PGRequest():
    PGMessageType: int
    # back test elements