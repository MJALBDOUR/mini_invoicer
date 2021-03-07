class Image {
  final String id;
  final String title;
  final String description;
  final String url;
  final bool sensitive;
  final DateTime timestamp;
  final String ownerId;

  const Image({
    this.id,
    this.title,
    this.description,
    this.url,
    this.sensitive,
    this.timestamp,
    this.ownerId,
  });

  factory Image.fromJson(String id, Map<String, dynamic> json) => Image(
        id: json['id'] as String,
        title: json['title'] as String,
        description: json['description'] as String,
        url: json['url'] as String,
        sensitive: json['sensitive'] as bool,
        timestamp: json['timestamp']?.toDate() as DateTime,
        ownerId: json['ownerId'] as String,
      );

  Map<String, dynamic> toJson() => {
        'title': this.title,
        'description': this.description,
        'url': this.url,
        'sensitive': this.sensitive,
        // timestamp is done server-side
        'ownerId': this.ownerId,
      };

  Map<String, dynamic> toJsonWithId() => {
        'id': this.id,
        'title': this.title,
        'description': this.description,
        'url': this.url,
        'sensitive': this.sensitive,
        // timestamp is done server-side
        'ownerId': this.ownerId,
      };
}