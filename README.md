# Employee Background Verification Prototype

A legacy ASP.NET Web Forms project that models a shared employment-history and verification workflow for employees, companies, and administrators.

The application was created as an academic prototype. It demonstrates a role-based web system and relational data workflow, but it is not suitable for real employment decisions or sensitive personal data.

## Application roles

- Employees maintain profile and employment information
- Companies review records and manage employment entries
- Administrators manage users and system activity

## Technology

- C#
- ASP.NET Web Forms
- SQL Server
- JavaScript and CSS

## Repository structure

```text
EBV/       Web application, role-specific pages, and project configuration
EBV.sln    Visual Studio solution
```

## Project status

This is an archived educational prototype built on .NET Framework 4.0. It requires a security and privacy redesign before it can be run with any real data.

Priority improvements:

- Rotate exposed database credentials and remove them from the repository and Git history
- Move configuration to environment variables or an ignored local file
- Replace sensitive identifiers with synthetic development data
- Add explicit consent, access controls, retention rules, and audit logs
- Review all database access for parameterized queries
- Add password hashing, authorization tests, and secure session handling
- Upgrade the framework and dependencies

## What I learned

- How to structure role-based screens in an ASP.NET application
- How application workflows map to relational records
- Why systems involving employment data require strong privacy boundaries
- Why working software is only one part of a trustworthy system

## Responsible use

Background checks affect employment opportunities and involve sensitive information. A real system would require legal review, informed consent, correction and appeal mechanisms, strict data minimization, and protections against discriminatory or inaccurate decisions. This repository provides none of those guarantees and should only be treated as a historical prototype.

## License

This repository is available under the MIT License. See `LICENSE.md` for details.

