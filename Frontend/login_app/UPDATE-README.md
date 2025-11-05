# UPDATE-README

## Changes Made to Login App

### What I Updated

**Upgraded React to Latest Version**
- Updated React from v18 to v19.2.0

**Fixed Login Form**
- Added React Hook Form for better form handling
- Form now properly validates name (min 2 characters) and password (min 6 characters)
- Form resets after successful submission
- Shows error messages when validation fails

**Improved Login Attempt List**
- Fixed the component to actually display login attempts
- Added filter functionality to search by name

**Added Tailwind CSS**
- Installed Tailwind CSS v3.4.18 for styling
- Made the UI look cleaner and more modern

### How to Run

```bash
npm install
npm start
```