CREATE TABLE eav_entity_type(
entity_type_id uniqueidentifier NOT NULL PRIMARY KEY,
entity_type_label nvarchar(30) NOT NULL
);

-- CUSTOMER / Product etc.



CREATE TABLE eav_entity(
entity_id uniqueidentifier NOT NULL PRIMARY KEY,
entity_type_id uniqueidentifier NOT NULL,

CONSTRAINT FK_eav_entity_eav_entity_type FOREIGN KEY(entity_type_id)
	REFERENCES eav_entity_type(entity_type_id)
	ON DELETE NO ACTION

);

-- SPECIFIC PRODUCT / CATEGORY/ CUSTOMER etc 


CREATE TABLE eav_attribute_type(
attribute_type_id uniqueidentifier NOT NULL PRIMARY KEY,
value_type nvarchar(30));



CREATE TABLE eav_attribute(
attribute_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_type_id uniqueidentifier NOT NULL,
entity_type_id uniqueidentifier NOT NULL,

CONSTRAINT FK_eav_attribute_eav_attribute_type FOREIGN KEY(attribute_type_id)
	REFERENCES eav_attribute_type(attribute_type_id)
	ON DELETE NO ACTION,
	
CONSTRAINT FK_eav_attribute_eav_entity_type FOREIGN KEY(entity_type_id)
	REFERENCES eav_entity_type(entity_type_id)
	ON DELETE NO ACTION
);

-- SPECIFIC ATTRIBUTE



/*CREATE TABLE eav_value(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value nvarchar(255) NOT NULL,

CONSTRAINT FK_eav_value_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id),
	
CONSTRAINT FK_eav_value_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
);*/

-- SPECIFIC ATTRIBUTE_VALUE with all values having varchar type


CREATE TABLE eav_value_nvarcar(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value nvarchar(255) NOT NULL,

CONSTRAINT FK_eav_value_nvarcar_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_nvarcar_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);




CREATE TABLE eav_value_ntext(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value ntext NOT NULL,

CONSTRAINT FK_eav_value_ntext_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_ntext_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);




CREATE TABLE eav_value_bit(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value bit NOT NULL,

CONSTRAINT FK_eav_value_bit_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_bit_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);




CREATE TABLE eav_value_datetime(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value datetime NOT NULL,

CONSTRAINT FK_eav_value_datetime_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_datetime_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);




CREATE TABLE eav_value_decimal(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value decimal NOT NULL,

CONSTRAINT FK_eav_value_decimal_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_decimal_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);



CREATE TABLE eav_value_float(
attribute_value_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL,
entity_id uniqueidentifier NOT NULL,
value float(53) NOT NULL,

CONSTRAINT FK_eav_value_float_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,
	
CONSTRAINT FK_eav_value_float_eav_entity FOREIGN KEY(entity_id)
	REFERENCES eav_entity(entity_id)
	ON DELETE CASCADE
);



CREATE TABLE eav_attribute_option(
option_id uniqueidentifier NOT NULL PRIMARY KEY,
attribute_id uniqueidentifier NOT NULL

CONSTRAINT FK_eav_attribute_option_eav_attribute FOREIGN KEY(attribute_id)
	REFERENCES eav_attribute(attribute_id)
	ON DELETE CASCADE,

);

-- OPTIONS FOR RSELECTABLE ATTRIBUTES




CREATE TABLE eav_attribute_option_value(
value_id uniqueidentifier NOT NULL PRIMARY KEY,
option_id uniqueidentifier UNIQUE NOT NULL,
value nvarchar(255) NOT NULL

CONSTRAINT FK_eav_attribute_option_value_eav_attribute_option FOREIGN KEY(option_id)
	REFERENCES eav_attribute_option(option_id)
	ON DELETE CASCADE
);


-- VALUES OF OPTIONS FOR SELECTABLE ATTRIBUTES