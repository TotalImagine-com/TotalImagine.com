# Data Procesing Patterns with Variant Logics

Tags: Programming, Design Pattern, Workflow

## Summary

In summary: 1) Provide core reusable logic as small functions; 2) Implement each variant as monolithic processing class, dated, with revision number; 3) Optionally adapt template pattern if enough varying instances are gathered and the pipeline contains clear stages, in which case we may use overrides instead of full monolithic classes.

Alternatively, core logic may be developed as library module, and use scripts as interface to drive parameter changes, e.g. in the Pure environment.

## Content

The problem with data processing mostly concerns several completely independent or irrelevant steps: 1) Data gathering, 2) Data transformation, 3) Data output/presentation. Ideally, the entire process is broken down into stages, where each stage may seperately contain those three steps. The key idea is we should fetch and validate all data before we start processing (instead of breakdown middle way because we found certain data are not available), and on the other hand, we should only fetch data when we need it - so we should break things down into stages, where each stage is safe and isolated from each other.

In terms of programming, we should also seperate presentation from output, because those are are better kept decoupled. For interactivity, certain layering or structuring of code is needed. Also, the frontend is better driven by scripts instead of full GUI applications due to ever changing nature of business logic.