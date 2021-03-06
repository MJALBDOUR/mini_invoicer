class ProductPricing {
  final String id;
  final double value;
  final int salesTax;
  final String description;
  final String productId;
  final String pricingId;
  final String currencyId;

  const ProductPricing({
    this.id,
    this.value,
    this.salesTax,
    this.description,
    this.productId,
    this.pricingId,
    this.currencyId,
  });

  factory ProductPricing.fromJson(String id, Map<String, dynamic> json) =>
      ProductPricing(
        id: id,
        value: json['value'] as double,
        salesTax: json['salesTax'] as int,
        description: json['description'] as String,
        productId: json['productId'] as String,
        pricingId: json['pricingId'] as String,
        currencyId: json['currencyId'] as String,
      );

  Map<String, dynamic> toJson() => {
        'value': this.value,
        'salesTax': this.salesTax,
        'description': this.description,
        'productId': this.productId,
        'pricingId': this.pricingId,
        'currencyId': this.currencyId,
      };

  Map<String, dynamic> toJsonWithId() => {
        'id': this.id,
        'value': this.value,
        'salesTax': this.salesTax,
        'description': this.description,
        'productId': this.productId,
        'pricingId': this.pricingId,
        'currencyId': this.currencyId,
      };
}
