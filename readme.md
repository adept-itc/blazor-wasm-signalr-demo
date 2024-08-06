# Adept IT Consultants (UK) Ltd

## Blazor WASM SignalR demo

### About this demo

This demo application uses Blazor WASM, SignalR, a RESTful API and C# to provide a simple realtime application example.

The intended use is to allow any users (accessing the Blazor WASM client) to see the same IoT Device state.

Any user can modify the state of an IoT Device (alarmed, open and locked) with the changes applied in realtime in any connected
browser session.

This allows the users to see the latest state for each IoT device without having to refresh the page and provides a launchpad 
for a real-world application, where new IoT devices can be registered and you can manage relevant IoT devices.

### How to use the demo

Using an IDE such as Visual Studio, you need to run both the RESTful API project (`Apps\AdeptItc.App.Api.Demo`) and the Blazor
WASM client (`Apps\AdeptItc.App.UI.Demo`).

Once the application is loaded, you can simulate different users by opening up the Blazor WASM url in different browsers / session.
Changing the state of an IoT Device in one browser will be updated immediately in any other clients.

## Contact us

This demo is a practical demonstration of turning our hands to new tech and applying a degree of business logic in a relatively
short timeframe.

We can add this sort of value to you, your business and clients so feel free to view my profile and make contact with us today!