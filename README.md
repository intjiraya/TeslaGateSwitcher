# TeslaGateSwitcher

A plugin for SCP: Secret Laboratory (Exiled version) that allows server administrators to toggle the activation of Tesla gates during gameplay.

## Description

TeslaGateSwitcher is a plugin designed for the SCP: Secret Laboratory game, specifically for the Exiled version. This plugin enables server administrators to control whether Tesla gates are activated at the start of a round. With this plugin, you can easily manage the gameplay mechanics related to Tesla gates.

## Features

- **Toggle Tesla Gates**: Easily enable or disable Tesla gates at the start of a round.
- **User-Friendly Commands**: Use simple commands to toggle the state of Tesla gates without needing to modify configuration files.
- **Compatibility**: Designed to work seamlessly with the latest version of SCP:SL Exiled (version 8.9.11).
- **Performance Optimized**: Lightweight and efficient, ensuring minimal impact on server performance.

## Installation

1. Download the latest release of the TeslaGateSwitcher plugin from the [releases page](https://github.com/intjiraya/TeslaGateSwitcher/releases).
2. Place the downloaded `.dll` file into the `plugins` folder of your SCP:SL Exiled server.
3. Restart your server to load the plugin.
4. Configure the plugin settings in the `config.yml` file if necessary.

## Configuration

The configuration file allows you to set the initial state of Tesla gates. Here’s an example of the configuration options:

```yaml
TeslaGateSwitcher:
# Plugin Enabled?
  is_enabled: true
  # Enable debug?
  debug: false
  # Enable Tesla gates at the start of the round?
  enable_tesla_gates_at_round_start: true
```

Adjust the `EnableTeslaGatesAtRoundStart` value to your desired state.

## Usage

Once installed and configured, the plugin will automatically apply the specified state of Tesla gates during gameplay. Players can use the command to toggle the Tesla gates at any time.

### Command

To toggle the Tesla gates, use the following command in the game:

```
TeslaToggle
```

You can also use the alias:

```
tt
```

## Support

For any issues or questions regarding the TeslaGateSwitcher plugin, please open an issue on the [GitHub repository](https://github.com/intjiraya/TeslaGateSwitcher/issues) or join our community Discord server for assistance.

## Contributing

Contributions are welcome! If you would like to contribute to the development of TeslaGateSwitcher, please fork the repository and submit a pull request. Make sure to follow the coding standards and include appropriate documentation for your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/intjiraya/TeslaGateSwitcher/blob/master/LICENSE) file for more details.
