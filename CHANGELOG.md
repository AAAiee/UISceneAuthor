# Changelog

All notable changes to UISceneAuthor are documented in this file.

The format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/), and versions follow [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- Foundation for version 0.1.0. Host project `UISceneAuthor.uproject` for Unreal Engine 5.6.
- `UISceneAuthor` runtime module with one log category, `LogUISceneAuthor`. No gameplay code.
- `UISceneAuthorEditor` editor module with empty startup and shutdown. No editor UI.
- `UISceneAuthorHost` game module so the editor target has a module to build.
- A GitHub Actions workflow. It checks that the `.uplugin` and `.uproject` files parse as JSON, and that required files exist.
