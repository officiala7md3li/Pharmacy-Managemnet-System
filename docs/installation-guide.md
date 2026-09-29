# Installation and Setup Guide

## Prerequisites
- Visual Studio 2022 (.NET Framework 4.7.2+)
- SQL Server 2019+ or LocalDB

## Database Configuration
1. Open `App.config`.
2. Update `connectionStrings` section with your SQL Server instance name.
3. Run `Update-Database` in Package Manager Console to apply migrations.