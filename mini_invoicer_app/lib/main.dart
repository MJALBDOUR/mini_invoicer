import 'package:flutter/material.dart';
import 'package:mini_invoicer_app/screens/auth/sign_in_screen.dart';
import 'package:mini_invoicer_app/screens/route_map.dart';

void main() => runApp(MiniInvoicer());

class MiniInvoicer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "Mini Invoicer",
      initialRoute: SignInScreen.route,
      routes: routeMap,
    );
  }
}
