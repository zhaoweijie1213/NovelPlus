/**
 * plugins/vuetify.ts
 *
 * Framework documentation: https://vuetifyjs.com`
 */

// Composables
import { createVuetify } from 'vuetify'
// Styles
import '@mdi/font/css/materialdesignicons.css'

import 'vuetify/styles'

export default createVuetify({
  theme: {
    defaultTheme: 'dark',
    themes: {
      light: {},
      dark: {},
    },
  },
})
