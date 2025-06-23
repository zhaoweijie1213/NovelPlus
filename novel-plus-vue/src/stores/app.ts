// Utilities
import { defineStore } from 'pinia'
import { useTheme } from 'vuetify'

export const useAppStore = defineStore('app', {
  state: () => ({
    theme: 'dark' as 'light' | 'dark',
  }),
  actions: {
    toggleTheme () {
      const theme = useTheme()
      this.theme = this.theme === 'dark' ? 'light' : 'dark'
      theme.global.name.value = this.theme
    },
  },
})
