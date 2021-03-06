import 'package:flutter/widgets.dart';

// Screens | Wrappers
import 'package:mini_invoicer_client/ui/screens/auth/auth_wrapper.dart';
import 'package:mini_invoicer_client/ui/screens/auth/auth_form_screen.dart';
import 'package:mini_invoicer_client/ui/screens/home_screen.dart';
import 'package:mini_invoicer_client/ui/screens/product/product_add_screen.dart';
import 'package:mini_invoicer_client/ui/screens/product/products_screen.dart';

Map<String, Widget Function(BuildContext)> routes = {
  AuthWrapper.ROUTE: (context) => AuthWrapper(),
  AuthFormScreen.ROUTE: (context) => AuthFormScreen(),
  HomeScreen.ROUTE: (context) => HomeScreen(),
  ProductsScreen.ROUTE: (context) => ProductsScreen(),
  ProductAddScreen.ROUTE: (context) => ProductAddScreen(),
};
